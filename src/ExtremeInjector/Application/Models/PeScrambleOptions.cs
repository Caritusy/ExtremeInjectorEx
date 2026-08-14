public sealed class PeScrambleOptions
{
	public bool ScrambleHeaderFields { get; set; }

	public bool InsertExtraSections { get; set; }

	public bool RemoveDebugData { get; set; }

	public bool CreateFakeDebugDirectory { get; set; }

	public bool ShiftSectionData { get; set; }

	public bool ModifyAssemblyCode { get; set; }

	public bool RemoveUselessData { get; set; }

	public bool MoveRelocationTable { get; set; }

	public bool RenameSections { get; set; }

	public bool ModifyImportTable { get; set; }

	public bool CreateNewEntryPoint { get; set; }

	public bool ShiftSectionMemory { get; set; }

	public bool StripSectionCharacteristics { get; set; }
}
