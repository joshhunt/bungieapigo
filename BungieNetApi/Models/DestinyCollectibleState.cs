using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A Flags Enumeration/bitmask where each bit represents a different state that the Collectible can be in. A collectible can be in any number of these states, and you can choose to use or ignore any or all of them when making your own UI that shows Collectible info. Our displays are going to honor them, but we're also the kind of people who only pretend to inhale before quickly passing it to the left. So, you know, do what you got to do.
	/// </summary>
	/// <summary>
	/// (All joking aside, please note the caveat I mention around the Invisible flag: there are cases where it is in the best interest of your users to honor these flags even if you're a "show all the data" person. Collector-oriented compulsion is a very unfortunate and real thing, and I would hate to instill that compulsion in others through showing them items that they cannot earn. Please consider this when you are making your own apps/sites.)
	/// </summary>
	[Flags]
	public enum DestinyCollectibleState
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// NotAcquired = 1
		/// If this flag is set, you have not yet obtained this collectible.
		/// </summary>
		[EnumMember(Value = "1")]
		NotAcquired = 1,

		/// <summary>
		/// Obscured = 2
		/// If this flag is set, the item is &quot;obscured&quot; to you: you can&#x2F;should use the alternate item hash found in DestinyCollectibleDefinition.stateInfo.obscuredOverrideItemHash when displaying this collectible instead of the default display info.
		/// </summary>
		[EnumMember(Value = "2")]
		Obscured = 2,

		/// <summary>
		/// Invisible = 4
		/// If this flag is set, the collectible should not be shown to the user.
		/// Please do consider honoring this flag. It is used - for example - to hide items that a person didn&#39;t get from the Eververse. I can&#39;t prevent these from being returned in definitions, because some people may have acquired them and thus they should show up: but I would hate for people to start feeling some variant of a Collector&#39;s Remorse about these items, and thus increasing their purchasing based on that compulsion. That would be a very unfortunate outcome, and one that I wouldn&#39;t like to see happen. So please, whether or not I&#39;m your mom, consider honoring this flag and don&#39;t show people invisible collectibles.
		/// </summary>
		[EnumMember(Value = "4")]
		Invisible = 4,

		/// <summary>
		/// CannotAffordMaterialRequirements = 8
		/// If this flag is set, the collectible requires payment for creating an instance of the item, and you are lacking in currency. Bring the benjamins next time. Or spinmetal. Whatever.
		/// </summary>
		[EnumMember(Value = "8")]
		CannotAffordMaterialRequirements = 8,

		/// <summary>
		/// InventorySpaceUnavailable = 16
		/// If this flag is set, you can&#39;t pull this item out of your collection because there&#39;s no room left in your inventory.
		/// </summary>
		[EnumMember(Value = "16")]
		InventorySpaceUnavailable = 16,

		/// <summary>
		/// UniquenessViolation = 32
		/// If this flag is set, you already have one of these items and can&#39;t have a second one.
		/// </summary>
		[EnumMember(Value = "32")]
		UniquenessViolation = 32,

		/// <summary>
		/// PurchaseDisabled = 64
		/// If this flag is set, the ability to pull this item out of your collection has been disabled.
		/// </summary>
		[EnumMember(Value = "64")]
		PurchaseDisabled = 64,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}