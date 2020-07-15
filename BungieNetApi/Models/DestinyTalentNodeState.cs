using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum DestinyTalentNodeState
	{
		/// <summary>
		/// Invalid = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Invalid = 0,

		/// <summary>
		/// CanUpgrade = 1
		/// </summary>
		[EnumMember(Value = "1")]
		CanUpgrade = 1,

		/// <summary>
		/// NoPoints = 2
		/// </summary>
		[EnumMember(Value = "2")]
		NoPoints = 2,

		/// <summary>
		/// NoPrerequisites = 3
		/// </summary>
		[EnumMember(Value = "3")]
		NoPrerequisites = 3,

		/// <summary>
		/// NoSteps = 4
		/// </summary>
		[EnumMember(Value = "4")]
		NoSteps = 4,

		/// <summary>
		/// NoUnlock = 5
		/// </summary>
		[EnumMember(Value = "5")]
		NoUnlock = 5,

		/// <summary>
		/// NoMaterial = 6
		/// </summary>
		[EnumMember(Value = "6")]
		NoMaterial = 6,

		/// <summary>
		/// NoGridLevel = 7
		/// </summary>
		[EnumMember(Value = "7")]
		NoGridLevel = 7,

		/// <summary>
		/// SwappingLocked = 8
		/// </summary>
		[EnumMember(Value = "8")]
		SwappingLocked = 8,

		/// <summary>
		/// MustSwap = 9
		/// </summary>
		[EnumMember(Value = "9")]
		MustSwap = 9,

		/// <summary>
		/// Complete = 10
		/// </summary>
		[EnumMember(Value = "10")]
		Complete = 10,

		/// <summary>
		/// Unknown = 11
		/// </summary>
		[EnumMember(Value = "11")]
		Unknown = 11,

		/// <summary>
		/// CreationOnly = 12
		/// </summary>
		[EnumMember(Value = "12")]
		CreationOnly = 12,

		/// <summary>
		/// Hidden = 13
		/// </summary>
		[EnumMember(Value = "13")]
		Hidden = 13,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}