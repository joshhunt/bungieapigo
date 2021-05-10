using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// In addition to item quantity information for vendor prices, this also has any optional information that may exist about how the item's quantity can be modified. (unfortunately not information that is able to be read outside of the BNet servers, but it's there)
    /// </summary>
    [DataContract]
    public class DestinyVendorItemQuantity
    {
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
            return this.Equals(input as DestinyVendorItemQuantity);
        }

        public bool Equals(DestinyVendorItemQuantity input)
        {
            if (input == null) return false;

            return
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

