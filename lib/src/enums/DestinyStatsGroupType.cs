using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// If the enum value is > 100, it is a "special" group that cannot be queried for directly (special cases apply to when they are returned, and are not relevant in general cases)
	/// </summary>
	
	public enum DestinyStatsGroupType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// General = 1
		/// </summary>
		[EnumMember(Value = "1")]
		General = 1,

		/// <summary>
		/// Weapons = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Weapons = 2,

		/// <summary>
		/// Medals = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Medals = 3,

		/// <summary>
		/// ReservedGroups = 100
		/// This is purely to serve as the dividing line between filterable and un-filterable groups. Below this number is a group you can pass as a filter. Above it are groups used in very specific circumstances and not relevant for filtering.
		/// </summary>
		[EnumMember(Value = "100")]
		ReservedGroups = 100,

		/// <summary>
		/// Leaderboard = 101
		/// Only applicable while generating leaderboards.
		/// </summary>
		[EnumMember(Value = "101")]
		Leaderboard = 101,

		/// <summary>
		/// Activity = 102
		/// These will *only* be consumed by GetAggregateStatsByActivity
		/// </summary>
		[EnumMember(Value = "102")]
		Activity = 102,

		/// <summary>
		/// UniqueWeapon = 103
		/// These are only consumed and returned by GetUniqueWeaponHistory
		/// </summary>
		[EnumMember(Value = "103")]
		UniqueWeapon = 103,

		/// <summary>
		/// Internal = 104
		/// </summary>
		[EnumMember(Value = "104")]
		Internal = 104,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}