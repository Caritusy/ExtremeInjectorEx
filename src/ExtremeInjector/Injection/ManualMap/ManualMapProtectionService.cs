using System;
using System.Collections.Generic;
using System.IO;

internal sealed class ManualMapProtectionRun
{
	internal ManualMapProtectionRun(long offset, long length, bool decommit, NativeTypes.Enum34 protection)
	{
		Offset = offset;
		Length = length;
		Decommit = decommit;
		Protection = protection;
	}

	internal long Offset { get; }

	internal long Length { get; }

	internal bool Decommit { get; }

	internal NativeTypes.Enum34 Protection { get; }
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

		uint imageSize = image.method_6().method_3().imethod_29();
		if (imageSize == 0)
		{
			throw new InvalidDataException("The image has an invalid SizeOfImage value.");
		}

		int pageCount = checked((int)(((ulong)imageSize + PageSize - 1) / PageSize));
		var retainedCharacteristics = new SectionCharacteristics[pageCount];
		var hasDiscardableContent = new bool[pageCount];
		uint headerSize = Math.Min(image.method_6().method_3().imethod_31(), imageSize);
		MarkPages(retainedCharacteristics, 0, headerSize, imageSize, SectionCharacteristics.flag_33);

		foreach (PeSectionHeader section in image.method_8())
		{
			uint sectionLength = Math.Max(section.method_2(), section.method_6());
			if ((section.method_18() & SectionCharacteristics.flag_28) != 0)
			{
				MarkPages(hasDiscardableContent, section.method_4(), sectionLength, imageSize);
			}
			else
			{
				MarkPages(retainedCharacteristics, section.method_4(), sectionLength, imageSize, section.method_18());
			}
		}

		var runs = new List<ManualMapProtectionRun>();
		int pageIndex = 0;
		while (pageIndex < pageCount)
		{
			bool decommit = ShouldDecommit(retainedCharacteristics, hasDiscardableContent, pageIndex);
			NativeTypes.Enum34 protection = GetProtection(retainedCharacteristics[pageIndex]);
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
		NativeTypes.Enum34 protection)
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

	private static NativeTypes.Enum34 GetProtection(SectionCharacteristics characteristics)
	{
		bool execute = (characteristics & SectionCharacteristics.flag_32) != 0;
		bool read = (characteristics & SectionCharacteristics.flag_33) != 0;
		bool write = (characteristics & SectionCharacteristics.flag_34) != 0;
		NativeTypes.Enum34 protection;
		if (execute)
		{
			protection = read
				? (write ? NativeTypes.Enum34.flag_2 : NativeTypes.Enum34.flag_1)
				: (write ? NativeTypes.Enum34.flag_3 : NativeTypes.Enum34.flag_0);
		}
		else
		{
			protection = read
				? (write ? NativeTypes.Enum34.flag_6 : NativeTypes.Enum34.flag_5)
				: (write ? NativeTypes.Enum34.flag_7 : NativeTypes.Enum34.flag_4);
		}

		if ((characteristics & SectionCharacteristics.flag_29) != 0)
		{
			protection |= NativeTypes.Enum34.flag_9;
		}

		return protection;
	}
}

internal static class ManualMapProtectionService
{
	internal static void Apply(ManualMapInjector injector, ManualMapInjector.Class172 mappedImage)
	{
		if (injector == null)
		{
			throw new ArgumentNullException(nameof(injector));
		}
		if (mappedImage == null)
		{
			throw new ArgumentNullException(nameof(mappedImage));
		}

		ManualMapProtectionPlan plan = ManualMapProtectionPlan.Create(mappedImage.method_0());
		foreach (ManualMapProtectionRun run in plan.Runs)
		{
			IntPtr address = mappedImage.method_2().smethod_9(run.Offset);
			bool applied = run.Decommit
				? injector.DecommitMappedRange(address, run.Length)
				: injector.ProtectMappedRange(address, run.Length, run.Protection);
			if (!applied)
			{
				throw new AccessViolationException("Unable to apply page-coalesced protection to the mapped image.");
			}
		}

		if (!injector.FlushMappedImage(mappedImage.method_2(), plan.ImageSize))
		{
			throw new AccessViolationException("Unable to flush the mapped image from the target process instruction cache.");
		}
	}
}
