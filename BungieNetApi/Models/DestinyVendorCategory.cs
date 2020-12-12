using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Information about the category and items currently sold in that category.
    /// </summary>
    [DataContract]
    public class DestinyVendorCategory
    {
        /// <summary>
        /// An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.
        /// </summary>
        [DataMember(Name = "displayCategoryIndex", EmitDefaultValue = false)]
        public long DisplayCategoryIndex { get; set; }

        /// <summary>
        /// An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.
        /// </summary>
        [DataMember(Name = "itemIndexes", EmitDefaultValue = false)]
        public List<long> ItemIndexes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorCategory);
        }

        public bool Equals(DestinyVendorCategory input)
        {
            if (input == null) return false;

            return
                (
                    DisplayCategoryIndex == input.DisplayCategoryIndex ||
                    (DisplayCategoryIndex.Equals(input.DisplayCategoryIndex))
                ) &&
                (
                    ItemIndexes == input.ItemIndexes ||
                    (ItemIndexes != null && ItemIndexes.SequenceEqual(input.ItemIndexes))
                ) ;
        }
    }
}

