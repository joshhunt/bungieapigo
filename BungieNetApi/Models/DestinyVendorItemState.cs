using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.
	/// </summary>
	[Flags]
	public enum DestinyVendorItemState
	{
		/// <summary>
		/// None = 0
		/// There are no augments on the item.
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Incomplete = 1
		/// Deprecated forever (probably). There was a time when Records were going to be implemented through Vendors, and this field was relevant. Now they&#39;re implemented through Presentation Nodes, and this field doesn&#39;t matter anymore.
		/// </summary>
		[EnumMember(Value = "1")]
		Incomplete = 1,

		/// <summary>
		/// RewardAvailable = 2
		/// Deprecated forever (probably). See the description of the &quot;Incomplete&quot; value for the juicy scoop.
		/// </summary>
		[EnumMember(Value = "2")]
		RewardAvailable = 2,

		/// <summary>
		/// Complete = 4
		/// Deprecated forever (probably). See the description of the &quot;Incomplete&quot; value for the juicy scoop.
		/// </summary>
		[EnumMember(Value = "4")]
		Complete = 4,

		/// <summary>
		/// New = 8
		/// This item is considered to be &quot;newly available&quot;, and should have some UI showing how shiny it is.
		/// </summary>
		[EnumMember(Value = "8")]
		New = 8,

		/// <summary>
		/// Featured = 16
		/// This item is being &quot;featured&quot;, and should be shiny in a different way from items that are merely new.
		/// </summary>
		[EnumMember(Value = "16")]
		Featured = 16,

		/// <summary>
		/// Ending = 32
		/// This item is only available for a limited time, and that time is approaching.
		/// </summary>
		[EnumMember(Value = "32")]
		Ending = 32,

		/// <summary>
		/// OnSale = 64
		/// This item is &quot;on sale&quot;. Get it while it&#39;s hot.
		/// </summary>
		[EnumMember(Value = "64")]
		OnSale = 64,

		/// <summary>
		/// Owned = 128
		/// This item is already owned.
		/// </summary>
		[EnumMember(Value = "128")]
		Owned = 128,

		/// <summary>
		/// WideView = 256
		/// This item should be shown with a &quot;wide view&quot; instead of normal icon view.
		/// </summary>
		[EnumMember(Value = "256")]
		WideView = 256,

		/// <summary>
		/// NexusAttention = 512
		/// This indicates that you should show some kind of attention-requesting indicator on the item, in a similar manner to items in the nexus that have such notifications.
		/// </summary>
		[EnumMember(Value = "512")]
		NexusAttention = 512,

		/// <summary>
		/// SetDiscount = 1024
		/// This indicates that the item has some sort of a &#39;set&#39; discount.
		/// </summary>
		[EnumMember(Value = "1024")]
		SetDiscount = 1024,

		/// <summary>
		/// PriceDrop = 2048
		/// This indicates that the item has a price drop.
		/// </summary>
		[EnumMember(Value = "2048")]
		PriceDrop = 2048,

		/// <summary>
		/// DailyOffer = 4096
		/// This indicates that the item is a daily offer.
		/// </summary>
		[EnumMember(Value = "4096")]
		DailyOffer = 4096,

		/// <summary>
		/// Charity = 8192
		/// This indicates that the item is for charity.
		/// </summary>
		[EnumMember(Value = "8192")]
		Charity = 8192,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}