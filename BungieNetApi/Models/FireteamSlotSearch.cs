using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum FireteamSlotSearch
	{
		/// <summary>
		/// NoSlotRestriction = 0
		/// </summary>
		[EnumMember(Value = "0")]
		NoSlotRestriction = 0,

		/// <summary>
		/// HasOpenPlayerSlots = 1
		/// </summary>
		[EnumMember(Value = "1")]
		HasOpenPlayerSlots = 1,

		/// <summary>
		/// HasOpenPlayerOrAltSlots = 2
		/// </summary>
		[EnumMember(Value = "2")]
		HasOpenPlayerOrAltSlots = 2,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}