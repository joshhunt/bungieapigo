using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// This enumeration represents the most restrictive type of gating that is being performed by an entity. This is useful as a shortcut to avoid a lot of lookups when determining whether the gating on an Entity applies to everyone equally, or to their specific Profile or Character states.
	/// </summary>
	/// <summary>
	/// None = There is no gating on this item.
	/// </summary>
	/// <summary>
	/// Global = The gating on this item is based entirely on global game state. It will be gated the same for everyone.
	/// </summary>
	/// <summary>
	/// Clan = The gating on this item is at the Clan level. For instance, if you're gated by Clan level this will be the case.
	/// </summary>
	/// <summary>
	/// Profile = The gating includes Profile-specific checks, but not on the Profile's characters. An example of this might be when you acquire an Emblem: the Emblem will be available in your Kiosk for all characters in your Profile from that point onward.
	/// </summary>
	/// <summary>
	/// Character = The gating includes Character-specific checks, including character level restrictions. An example of this might be an item that you can't purchase from a Vendor until you reach a specific Character Level.
	/// </summary>
	/// <summary>
	/// Item = The gating includes item-specific checks. For BNet, this generally implies that we'll show this data only on a character level or deeper.
	/// </summary>
	/// <summary>
	/// AssumedWorstCase = The unlocks and checks being used for this calculation are of an unknown type and are used for unknown purposes. For instance, if some great person decided that an unlock value should be globally scoped, but then the game changes it using character-specific data in a way that BNet doesn't know about. Because of the open-ended potential for this to occur, many unlock checks for "globally" scoped unlock data may be assumed as the worst case unless it has been specifically whitelisted as otherwise. That sucks, but them's the breaks.
	/// </summary>
	
	public enum DestinyGatingScope
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Global = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Global = 1,

		/// <summary>
		/// Clan = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Clan = 2,

		/// <summary>
		/// Profile = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Profile = 3,

		/// <summary>
		/// Character = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Character = 4,

		/// <summary>
		/// Item = 5
		/// </summary>
		[EnumMember(Value = "5")]
		Item = 5,

		/// <summary>
		/// AssumedWorstCase = 6
		/// </summary>
		[EnumMember(Value = "6")]
		AssumedWorstCase = 6,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}