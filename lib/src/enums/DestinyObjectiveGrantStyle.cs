using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Some Objectives provide perks, generally as part of providing some kind of interesting modifier for a Challenge or Quest. This indicates when the Perk is granted.
	/// </summary>
	
	public enum DestinyObjectiveGrantStyle
	{
		/// <summary>
		/// WhenIncomplete = 0
		/// </summary>
		[EnumMember(Value = "0")]
		WhenIncomplete = 0,

		/// <summary>
		/// WhenComplete = 1
		/// </summary>
		[EnumMember(Value = "1")]
		WhenComplete = 1,

		/// <summary>
		/// Always = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Always = 2,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}