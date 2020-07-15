using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum DestinyStatsCategoryType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Kills = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Kills = 1,

		/// <summary>
		/// Assists = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Assists = 2,

		/// <summary>
		/// Deaths = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Deaths = 3,

		/// <summary>
		/// Criticals = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Criticals = 4,

		/// <summary>
		/// KDa = 5
		/// </summary>
		[EnumMember(Value = "5")]
		KDa = 5,

		/// <summary>
		/// KD = 6
		/// </summary>
		[EnumMember(Value = "6")]
		KD = 6,

		/// <summary>
		/// Score = 7
		/// </summary>
		[EnumMember(Value = "7")]
		Score = 7,

		/// <summary>
		/// Entered = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Entered = 8,

		/// <summary>
		/// TimePlayed = 9
		/// </summary>
		[EnumMember(Value = "9")]
		TimePlayed = 9,

		/// <summary>
		/// MedalWins = 10
		/// </summary>
		[EnumMember(Value = "10")]
		MedalWins = 10,

		/// <summary>
		/// MedalGame = 11
		/// </summary>
		[EnumMember(Value = "11")]
		MedalGame = 11,

		/// <summary>
		/// MedalSpecialKills = 12
		/// </summary>
		[EnumMember(Value = "12")]
		MedalSpecialKills = 12,

		/// <summary>
		/// MedalSprees = 13
		/// </summary>
		[EnumMember(Value = "13")]
		MedalSprees = 13,

		/// <summary>
		/// MedalMultiKills = 14
		/// </summary>
		[EnumMember(Value = "14")]
		MedalMultiKills = 14,

		/// <summary>
		/// MedalAbilities = 15
		/// </summary>
		[EnumMember(Value = "15")]
		MedalAbilities = 15,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}