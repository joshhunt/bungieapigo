using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum DestinyTalentNodeStepGuardianAttributes
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Stats = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Stats = 1,

		/// <summary>
		/// Shields = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Shields = 2,

		/// <summary>
		/// Health = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Health = 4,

		/// <summary>
		/// Revive = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Revive = 8,

		/// <summary>
		/// AimUnderFire = 16
		/// </summary>
		[EnumMember(Value = "16")]
		AimUnderFire = 16,

		/// <summary>
		/// Radar = 32
		/// </summary>
		[EnumMember(Value = "32")]
		Radar = 32,

		/// <summary>
		/// Invisibility = 64
		/// </summary>
		[EnumMember(Value = "64")]
		Invisibility = 64,

		/// <summary>
		/// Reputations = 128
		/// </summary>
		[EnumMember(Value = "128")]
		Reputations = 128,

		/// <summary>
		/// All = 255
		/// </summary>
		[EnumMember(Value = "255")]
		All = 255,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}