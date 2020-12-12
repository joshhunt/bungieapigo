using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// The base class for Vendor Sale Item data. Has a bunch of character-agnostic state about the item being sold.
    /// </summary>
    /// <summary>
    /// Note that if you want instance, stats, etc... data for the item, you'll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse's "items" property.
    /// </summary>
    [DataContract]
    public class DestinyVendorSaleItemBaseComponent
    {
        /// <summary>
        /// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch. 
        /// </summary>
        /// <summary>
        /// Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
        /// </summary>
        [DataMember(Name = "vendorItemIndex", EmitDefaultValue = false)]
        public long VendorItemIndex { get; set; }

        /// <summary>
        /// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.
        /// </summary>
        /// <summary>
        /// If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
        /// </summary>
        [DataMember(Name = "overrideStyleItemHash", EmitDefaultValue = false)]
        public uint OverrideStyleItemHash { get; set; }

        /// <summary>
        /// How much of the item you'll be getting.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// A summary of the current costs of the item.
        /// </summary>
        [DataMember(Name = "costs", EmitDefaultValue = false)]
        public List<DestinyItemQuantity> Costs { get; set; }

        /// <summary>
        /// If this item has its own custom date where it may be removed from the Vendor's rotation, this is that date.
        /// </summary>
        /// <summary>
        /// Note that there's not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor's sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it's the best we can give.
        /// </summary>
        [DataMember(Name = "overrideNextRefreshDate", EmitDefaultValue = false)]
        public DateTime OverrideNextRefreshDate { get; set; }

        /// <summary>
        /// If true, this item can be purchased through the Bungie.net API.
        /// </summary>
        [DataMember(Name = "apiPurchasable", EmitDefaultValue = false)]
        public bool ApiPurchasable { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemBaseComponent);
        }

        public bool Equals(DestinyVendorSaleItemBaseComponent input)
        {
            if (input == null) return false;

            return
                (
                    VendorItemIndex == input.VendorItemIndex ||
                    (VendorItemIndex.Equals(input.VendorItemIndex))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    (OverrideStyleItemHash.Equals(input.OverrideStyleItemHash))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity.Equals(input.Quantity))
                ) &&
                (
                    Costs == input.Costs ||
                    (Costs != null && Costs.SequenceEqual(input.Costs))
                ) &&
                (
                    OverrideNextRefreshDate == input.OverrideNextRefreshDate ||
                    (OverrideNextRefreshDate != null && OverrideNextRefreshDate.Equals(input.OverrideNextRefreshDate))
                ) &&
                (
                    ApiPurchasable == input.ApiPurchasable ||
                    (ApiPurchasable != null && ApiPurchasable.Equals(input.ApiPurchasable))
                ) ;
        }
    }
}

