public static class TokenPrivilegeNativeTypes
{
	public struct TokenPrivileges
	{
		public uint PrivilegeCount;

		public Luid PrivilegeLuid;

		public uint Attributes;
	}

	public struct Luid
	{
		public uint LowPart;

		public int HighPart;
	}

	public enum TokenInformationClass
	{
		TokenUser = 1,
		TokenGroups,
		TokenPrivileges,
		TokenOwner,
		TokenPrimaryGroup,
		TokenDefaultDacl,
		TokenSource,
		TokenType,
		TokenImpersonationLevel,
		TokenStatistics,
		TokenRestrictedSids,
		TokenSessionId,
		TokenGroupsAndPrivileges,
		TokenSessionReference,
		TokenSandboxInert,
		TokenAuditPolicy,
		TokenOrigin,
		TokenElevationType,
		TokenLinkedToken,
		TokenElevation,
		TokenHasRestrictions,
		TokenAccessInformation,
		TokenVirtualizationAllowed,
		TokenVirtualizationEnabled,
		TokenIntegrityLevel,
		TokenUiAccess,
		TokenMandatoryPolicy,
		TokenLogonSid,
		MaximumTokenInformationClass
	}

	public enum TokenElevationType
	{
		Default = 1,
		Full,
		Limited
	}
}
