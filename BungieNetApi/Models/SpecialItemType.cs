using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via direct data, add a new classification here and use a string constant to represent it in the local item config file.
	/// </summary>
	/// <summary>
	/// NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
	/// </summary>
	
	public enum SpecialItemType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// SpecialCurrency = 1
		/// </summary>
		[EnumMember(Value = "1")]
		SpecialCurrency = 1,

		/// <summary>
		/// Armor = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Armor = 8,

		/// <summary>
		/// Weapon = 9
		/// </summary>
		[EnumMember(Value = "9")]
		Weapon = 9,

		/// <summary>
		/// Engram = 23
		/// </summary>
		[EnumMember(Value = "23")]
		Engram = 23,

		/// <summary>
		/// Consumable = 24
		/// </summary>
		[EnumMember(Value = "24")]
		Consumable = 24,

		/// <summary>
		/// ExchangeMaterial = 25
		/// </summary>
		[EnumMember(Value = "25")]
		ExchangeMaterial = 25,

		/// <summary>
		/// MissionReward = 27
		/// </summary>
		[EnumMember(Value = "27")]
		MissionReward = 27,

		/// <summary>
		/// Currency = 29
		/// </summary>
		[EnumMember(Value = "29")]
		Currency = 29,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}