using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Request this component if you want the details about an item being sold in relation to the character making the request: whether the character can buy it, whether they can afford it, and other data related to purchasing the item.
	/// </summary>
	/// <summary>
	/// Note that if you want instance, stats, etc... data for the item, you'll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse's "items" property.
	/// </summary>
	[DataContract]
	public class DestinyVendorSaleItemComponent{

		/// <summary>
		/// A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can't buy it.
		/// </summary>
		[DataMember(Name="saleStatus", EmitDefaultValue=false)]
		public VendorItemStatus SaleStatus { get; set; }

		/// <summary>
		/// If you can't buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)
		/// </summary>
		/// <summary>
		/// Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
		/// </summary>
		[DataMember(Name="requiredUnlocks", EmitDefaultValue=false)]
		public List<uint> RequiredUnlocks { get; set; }

		/// <summary>
		/// If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.
		/// </summary>
		/// <summary>
		/// Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
		/// </summary>
		[DataMember(Name="unlockStatuses", EmitDefaultValue=false)]
		public List<DestinyUnlockStatus> UnlockStatuses { get; set; }

		/// <summary>
		/// Indexes in to the "failureStrings" lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can't purchase an item.
		/// </summary>
		/// <summary>
		/// It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn't anticipate.
		/// </summary>
		[DataMember(Name="failureIndexes", EmitDefaultValue=false)]
		public List<long> FailureIndexes { get; set; }

		/// <summary>
		/// A flags enumeration value representing the current state of any "state modifiers" on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.
		/// </summary>
		/// <summary>
		/// Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.
		/// </summary>
		[DataMember(Name="augments", EmitDefaultValue=false)]
		public DestinyVendorItemState Augments { get; set; }

		/// <summary>
		/// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch. 
		/// </summary>
		/// <summary>
		/// Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
		/// </summary>
		[DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
		public long VendorItemIndex { get; set; }

		/// <summary>
		/// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.
		/// </summary>
		/// <summary>
		/// If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
		/// </summary>
		[DataMember(Name="overrideStyleItemHash", EmitDefaultValue=false)]
		public uint OverrideStyleItemHash { get; set; }

		/// <summary>
		/// How much of the item you'll be getting.
		/// </summary>
		[DataMember(Name="quantity", EmitDefaultValue=false)]
		public long Quantity { get; set; }

		/// <summary>
		/// A summary of the current costs of the item.
		/// </summary>
		[DataMember(Name="costs", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> Costs { get; set; }

		/// <summary>
		/// If this item has its own custom date where it may be removed from the Vendor's rotation, this is that date.
		/// </summary>
		/// <summary>
		/// Note that there's not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor's sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it's the best we can give.
		/// </summary>
		[DataMember(Name="overrideNextRefreshDate", EmitDefaultValue=false)]
		public string OverrideNextRefreshDate { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemComponent);
        }

		public bool Equals(DestinyVendorSaleItemComponent input)
		{
			if (input == null) return false;

			return
				(
                    SaleStatus == input.SaleStatus ||
                    (SaleStatus != null && SaleStatus.Equals(input.SaleStatus))
                ) &&
				(
                    RequiredUnlocks == input.RequiredUnlocks ||
                    (RequiredUnlocks != null && RequiredUnlocks.Equals(input.RequiredUnlocks))
                ) &&
				(
                    UnlockStatuses == input.UnlockStatuses ||
                    (UnlockStatuses != null && UnlockStatuses.Equals(input.UnlockStatuses))
                ) &&
				(
                    FailureIndexes == input.FailureIndexes ||
                    (FailureIndexes != null && FailureIndexes.Equals(input.FailureIndexes))
                ) &&
				(
                    Augments == input.Augments ||
                    (Augments != null && Augments.Equals(input.Augments))
                ) &&
				(
                    VendorItemIndex == input.VendorItemIndex ||
                    (VendorItemIndex != null && VendorItemIndex.Equals(input.VendorItemIndex))
                ) &&
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    (OverrideStyleItemHash != null && OverrideStyleItemHash.Equals(input.OverrideStyleItemHash))
                ) &&
				(
                    Quantity == input.Quantity ||
                    (Quantity != null && Quantity.Equals(input.Quantity))
                ) &&
				(
                    Costs == input.Costs ||
                    (Costs != null && Costs.Equals(input.Costs))
                ) &&
				(
                    OverrideNextRefreshDate == input.OverrideNextRefreshDate ||
                    (OverrideNextRefreshDate != null && OverrideNextRefreshDate.Equals(input.OverrideNextRefreshDate))
                ) ;
		}
	}
}

