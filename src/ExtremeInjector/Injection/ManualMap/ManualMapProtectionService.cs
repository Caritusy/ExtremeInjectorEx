using System;
using System.Collections.Generic;
using System.IO;

internal sealed class ManualMapProtectionRun
{
	internal ManualMapProtectionRun(long offset, long length, bool decommit, NativeTypes.MemoryProtection protection)
	{
		Offset = offset;
		Length = length;
		Decommit = decommit;
		Protection = protection;
	}

	internal long Offset { get; }

	internal long Length { get; }

	internal bool Decommit { get; }

	internal NativeTypes.MemoryProtection Protection { get; }
}

internal sealed class ManualMapProtectionPlan
{
	private const uint PageSize = 0x1000;

	private ManualMapProtectionPlan(uint imageSize, IReadOnlyList<ManualMapProtectionRun> runs)
	{
		ImageSize = imageSize;
		Runs = runs;
	}

	internal uint ImageSize { get; }

	internal IReadOnlyList<ManualMapProtectionRun> Runs { get; }

	internal static ManualMapProtectionPlan Create(PeImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException(nameof(image));
		}

		uint imageSize = image.GetHeaders().GetOptionalHeader().GetSizeOfImage();
		if (imageSize == 0)
		{
			throw new InvalidDataException("The image has an invalid SizeOfImage value.");
		}

		int pageCount = checked((int)(((ulong)imageSize + PageSize - 1) / PageSize));
		var retainedCharacteristics = new SectionCharacteristics[pageCount];
		var hasDiscardableContent = new bool[pageCount];
		uint headerSize = Math.Min(image.GetHeaders().GetOptionalHeader().GetSizeOfHeaders(), imageSize);
		MarkPages(retainedCharacteristics, 0, headerSize, imageSize, SectionCharacteristics.Read);

		foreach (PeSectionHeader section in image.GetSections())
		{
			uint sectionLength = Math.Max(section.GetVirtualSize(), section.GetSizeOfRawData());
			if ((section.GetCharacteristics() & SectionCharacteristics.Discardable) != 0)
			{
				MarkPages(hasDiscardableContent, section.GetVirtualAddress(), sectionLength, imageSize);
			}
			else
			{
				MarkPages(retainedCharacteristics, section.GetVirtualAddress(), sectionLength, imageSize, section.GetCharacteristics());
			}
		}

		var runs = new List<ManualMapProtectionRun>();
		int pageIndex = 0;
		while (pageIndex < pageCount)
		{
			bool decommit = ShouldDecommit(retainedCharacteristics, hasDiscardableContent, pageIndex);
			NativeTypes.MemoryProtection protection = GetProtection(retainedCharacteristics[pageIndex]);
			int runEnd = pageIndex + 1;
			while (runEnd < pageCount && HasSameAction(
				retainedCharacteristics,
				hasDiscardableContent,
				runEnd,
				decommit,
				protection))
			{
				runEnd++;
			}

			long offset = (long)pageIndex * PageSize;
			long length = Math.Min((long)(runEnd - pageIndex) * PageSize, imageSize - offset);
			runs.Add(new ManualMapProtectionRun(offset, length, decommit, protection));
			pageIndex = runEnd;
		}

		return new ManualMapProtectionPlan(imageSize, runs);
	}

	private static bool HasSameAction(
		SectionCharacteristics[] retained,
		bool[] discardable,
		int pageIndex,
		bool decommit,
		NativeTypes.MemoryProtection protection)
	{
		bool nextDecommit = ShouldDecommit(retained, discardable, pageIndex);
		return nextDecommit == decommit && (decommit || GetProtection(retained[pageIndex]) == protection);
	}

	private static bool ShouldDecommit(SectionCharacteristics[] retained, bool[] discardable, int pageIndex)
	{
		return retained[pageIndex] == 0 && discardable[pageIndex];
	}

	private static void MarkPages(
		SectionCharacteristics[] pages,
		uint start,
		uint length,
		uint imageSize,
		SectionCharacteristics characteristics)
	{
		VisitPages(start, length, imageSize, index => pages[index] |= characteristics);
	}

	private static void MarkPages(bool[] pages, uint start, uint length, uint imageSize)
	{
		VisitPages(start, length, imageSize, index => pages[index] = true);
	}

	private static void VisitPages(uint start, uint length, uint imageSize, Action<int> visit)
	{
		if (length == 0 || start >= imageSize)
		{
			return;
		}

		ulong end = Math.Min((ulong)start + length, imageSize);
		int firstPage = (int)(start / PageSize);
		int lastPage = (int)((end - 1) / PageSize);
		for (int index = firstPage; index <= lastPage; index++)
		{
			visit(index);
		}
	}

	private static NativeTypes.MemoryProtection GetProtection(SectionCharacteristics characteristics)
	{
		bool execute = (characteristics & SectionCharacteristics.Execute) != 0;
		bool read = (characteristics & SectionCharacteristics.Read) != 0;
		bool write = (characteristics & SectionCharacteristics.Write) != 0;
		NativeTypes.MemoryProtection protection;
		if (execute)
		{
			protection = read
				? (write ? NativeTypes.MemoryProtection.ExecuteReadWrite : NativeTypes.MemoryProtection.ExecuteRead)
				: (write ? NativeTypes.MemoryProtection.ExecuteWriteCopy : NativeTypes.MemoryProtection.Execute);
		}
		else
		{
			protection = read
				? (write ? NativeTypes.MemoryProtection.ReadWrite : NativeTypes.MemoryProtection.ReadOnly)
				: (write ? NativeTypes.MemoryProtection.WriteCopy : NativeTypes.MemoryProtection.NoAccess);
		}

		if ((characteristics & SectionCharacteristics.NotCached) != 0)
		{
			protection |= NativeTypes.MemoryProtection.NoCache;
		}

		return protection;
	}
}

internal static class ManualMapProtectionService
{
	internal static void Apply(ManualMapInjector injector, ManualMapInjector.MappingContext mappedImage)
	{
		if (injector == null)
		{
			throw new ArgumentNullException(nameof(injector));
		}
		if (mappedImage == null)
		{
			throw new ArgumentNullException(nameof(mappedImage));
		}

		ManualMapProtectionPlan plan = ManualMapProtectionPlan.Create(mappedImage.GetImage());
		foreach (ManualMapProtectionRun run in plan.Runs)
		{
			IntPtr address = mappedImage.GetModuleBase().Add(run.Offset);
			bool applied = run.Decommit
				? injector.DecommitMappedRange(address, run.Length)
				: injector.ProtectMappedRange(address, run.Length, run.Protection);
			if (!applied)
			{
				throw new AccessViolationException("Unable to apply page-coalesced protection to the mapped image.");
			}
		}

		if (!injector.FlushMappedImage(mappedImage.GetModuleBase(), plan.ImageSize))
		{
			throw new AccessViolationException("Unable to flush the mapped image from the target process instruction cache.");
		}
	}
}
