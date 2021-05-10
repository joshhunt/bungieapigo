using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// A subclass of DestinyItemQuantity, that provides not just the item and its quantity but also information that BNet can - at some point - use internally to provide more robust runtime information about the item's qualities.
    /// </summary>
    /// <summary>
    /// If you want it, please ask! We're just out of time to wire it up right now. Or a clever person just may do it with our existing endpoints.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneQuestRewardItem
    {
        /// <summary>
        /// The quest reward item *may* be associated with a vendor. If so, this is that vendor. Use this hash to look up the DestinyVendorDefinition.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }

        /// <summary>
        /// The quest reward item *may* be associated with a vendor. If so, this is the index of the item being sold, which we can use at runtime to find instanced item information for the reward item.
        /// </summary>
        [DataMember(Name = "vendorItemIndex", EmitDefaultValue = false)]
        public long VendorItemIndex { get; set; }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress.
        /// </summary>
        [DataMember(Name = "hasConditionalVisibility", EmitDefaultValue = false)]
        public bool HasConditionalVisibility { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneQuestRewardItem);
        }

        public bool Equals(DestinyMilestoneQuestRewardItem input)
        {
            if (input == null) return false;

            return
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash.Equals(input.VendorHash))
                ) &&
                (
                    VendorItemIndex == input.VendorItemIndex ||
                    (VendorItemIndex.Equals(input.VendorItemIndex))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity.Equals(input.Quantity))
                ) &&
                (
                    HasConditionalVisibility == input.HasConditionalVisibility ||
                    (HasConditionalVisibility != null && HasConditionalVisibility.Equals(input.HasConditionalVisibility))
                ) ;
        }
    }
}

