using System.Collections.Generic;
using System.IO;
using System.Text;

public sealed class PeImageWriter
{
	internal PeImage peImage;

	internal BinaryWriter binaryWriter;

	internal Stream stream;

	public PeImageWriter(PeImage peImage2)
	{
		this.peImage = peImage2;
	}

	internal void WriteSectionHeaders()
	{
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			this.binaryWriter.Write(Encoding.ASCII.GetBytes(gclass.GetName().PadRight(8, '\0')));
			this.binaryWriter.Write(gclass.GetVirtualSize());
			this.binaryWriter.Write(gclass.GetVirtualAddress());
			this.binaryWriter.Write(gclass.GetSizeOfRawData());
			this.binaryWriter.Write(gclass.GetPointerToRawData());
			this.binaryWriter.Write(gclass.GetPointerToRelocations());
			this.binaryWriter.Write(gclass.GetPointerToLineNumbers());
			this.binaryWriter.Write(gclass.GetNumberOfRelocations());
			this.binaryWriter.Write(gclass.GetNumberOfLineNumbers());
			this.binaryWriter.Write((uint)gclass.GetCharacteristics());
		}
	}
}
