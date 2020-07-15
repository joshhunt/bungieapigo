using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum Capabilities
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Leaderboards = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Leaderboards = 1,

		/// <summary>
		/// Callsign = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Callsign = 2,

		/// <summary>
		/// OptionalConversations = 4
		/// </summary>
		[EnumMember(Value = "4")]
		OptionalConversations = 4,

		/// <summary>
		/// ClanBanner = 8
		/// </summary>
		[EnumMember(Value = "8")]
		ClanBanner = 8,

		/// <summary>
		/// D2InvestmentData = 16
		/// </summary>
		[EnumMember(Value = "16")]
		D2InvestmentData = 16,

		/// <summary>
		/// Tags = 32
		/// </summary>
		[EnumMember(Value = "32")]
		Tags = 32,

		/// <summary>
		/// Alliances = 64
		/// </summary>
		[EnumMember(Value = "64")]
		Alliances = 64,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}