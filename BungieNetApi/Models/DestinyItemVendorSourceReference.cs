using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents that a vendor could sell this item, and provides a quick link to that vendor and sale item.
    /// </summary>
    /// <summary>
    ///  Note that we do not and cannot make a guarantee that the vendor will ever *actually* sell this item, only that the Vendor has a definition that indicates it *could* be sold.
    /// </summary>
    /// <summary>
    ///  Note also that a vendor may sell the same item in multiple "ways", which means there may be multiple vendorItemIndexes for a single Vendor hash.
    /// </summary>
    [DataContract]
    public class DestinyItemVendorSourceReference
    {
        /// <summary>
        /// The identifier for the vendor that may sell this item.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }

        /// <summary>
        /// The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple "ways", hence why this is a list. (for instance, a weapon may be "sold" as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index)
        /// </summary>
        [DataMember(Name = "vendorItemIndexes", EmitDefaultValue = false)]
        public List<long> VendorItemIndexes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemVendorSourceReference);
        }

        public bool Equals(DestinyItemVendorSourceReference input)
        {
            if (input == null) return false;

            return
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
                (
                    VendorItemIndexes == input.VendorItemIndexes ||
                    (VendorItemIndexes != null && VendorItemIndexes.Equals(input.VendorItemIndexes))
                ) ;
        }
    }
}

