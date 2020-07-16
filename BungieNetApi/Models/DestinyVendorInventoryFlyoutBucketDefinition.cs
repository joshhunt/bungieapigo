using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Information about a single inventory bucket in a vendor flyout UI and how it is shown.
    /// </summary>
    [DataContract]
    public class DestinyVendorInventoryFlyoutBucketDefinition
    {
        /// <summary>
        /// If true, the inventory bucket should be able to be collapsed visually.
        /// </summary>
        [DataMember(Name = "collapsible", EmitDefaultValue = false)]
        public bool Collapsible { get; set; }

        /// <summary>
        /// The inventory bucket whose contents should be shown.
        /// </summary>
        [DataMember(Name = "inventoryBucketHash", EmitDefaultValue = false)]
        public uint InventoryBucketHash { get; set; }

        /// <summary>
        /// The methodology to use for sorting items from the flyout.
        /// </summary>
        [DataMember(Name = "sortItemsBy", EmitDefaultValue = false)]
        public DestinyItemSortType SortItemsBy { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInventoryFlyoutBucketDefinition);
        }

        public bool Equals(DestinyVendorInventoryFlyoutBucketDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Collapsible == input.Collapsible ||
                    (Collapsible != null && Collapsible.Equals(input.Collapsible))
                ) &&
                (
                    InventoryBucketHash == input.InventoryBucketHash ||
                    (InventoryBucketHash != null && InventoryBucketHash.Equals(input.InventoryBucketHash))
                ) &&
                (
                    SortItemsBy == input.SortItemsBy ||
                    (SortItemsBy != null && SortItemsBy.Equals(input.SortItemsBy))
                ) ;
        }
    }
}

