using System.Collections.Generic;
using System.IO;
using System.Text;

public sealed class PeImageWriter
{
	internal PeImage class154_0;

	internal BinaryWriter binaryWriter_0;

	internal Stream stream_0;

	public PeImageWriter(PeImage class154_1)
	{
		this.class154_0 = class154_1;
	}

	internal void WriteSectionHeaders()
	{
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			this.binaryWriter_0.Write(Encoding.ASCII.GetBytes(gclass.GetName().PadRight(8, '\0')));
			this.binaryWriter_0.Write(gclass.GetVirtualSize());
			this.binaryWriter_0.Write(gclass.GetVirtualAddress());
			this.binaryWriter_0.Write(gclass.GetSizeOfRawData());
			this.binaryWriter_0.Write(gclass.GetPointerToRawData());
			this.binaryWriter_0.Write(gclass.GetPointerToRelocations());
			this.binaryWriter_0.Write(gclass.GetPointerToLineNumbers());
			this.binaryWriter_0.Write(gclass.GetNumberOfRelocations());
			this.binaryWriter_0.Write(gclass.GetNumberOfLineNumbers());
			this.binaryWriter_0.Write((uint)gclass.GetCharacteristics());
		}
	}
}
