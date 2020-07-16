using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// A shortcut for the fact that some items have a "Preview Vendor" - See DestinyInventoryItemDefinition.preview.previewVendorHash - that is intended to be used to show what items you can get as a result of acquiring or using this item.
    /// </summary>
    /// <summary>
    /// A common example of this in Destiny 1 was Eververse "Boxes," which could have many possible items. This "Preview Vendor" is not a vendor you can actually see in the game, but it defines categories and sale items for all of the possible items you could get from the Box so that the game can show them to you. We summarize that info here so that you don't have to do that Vendor lookup and aggregation manually.
    /// </summary>
    [DataContract]
    public class DestinyDerivedItemCategoryDefinition
    {
        /// <summary>
        /// The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you'll get.
        /// </summary>
        [DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// This is the list of all of the items for this category and the basic properties we'll know about them.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<DestinyDerivedItemDefinition> Items { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDerivedItemCategoryDefinition);
        }

        public bool Equals(DestinyDerivedItemCategoryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    CategoryDescription == input.CategoryDescription ||
                    (CategoryDescription != null && CategoryDescription.Equals(input.CategoryDescription))
                ) &&
                (
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) ;
        }
    }
}

