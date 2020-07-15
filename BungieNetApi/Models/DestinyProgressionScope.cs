using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various "Scopes" of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
	/// </summary>
	
	public enum DestinyProgressionScope
	{
		/// <summary>
		/// Account = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Account = 0,

		/// <summary>
		/// Character = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Character = 1,

		/// <summary>
		/// Clan = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Clan = 2,

		/// <summary>
		/// Item = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Item = 3,

		/// <summary>
		/// ImplicitFromEquipment = 4
		/// </summary>
		[EnumMember(Value = "4")]
		ImplicitFromEquipment = 4,

		/// <summary>
		/// Mapped = 5
		/// </summary>
		[EnumMember(Value = "5")]
		Mapped = 5,

		/// <summary>
		/// MappedAggregate = 6
		/// </summary>
		[EnumMember(Value = "6")]
		MappedAggregate = 6,

		/// <summary>
		/// MappedStat = 7
		/// </summary>
		[EnumMember(Value = "7")]
		MappedStat = 7,

		/// <summary>
		/// MappedUnlockValue = 8
		/// </summary>
		[EnumMember(Value = "8")]
		MappedUnlockValue = 8,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}