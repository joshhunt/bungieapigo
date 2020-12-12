using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// A response containing all of the components for all requested vendors.
    /// </summary>
    [DataContract]
    public class InventoryChangedResponse
    {
        /// <summary>
        /// Items that appeared in the inventory possibly as a result of an action.
        /// </summary>
        [DataMember(Name = "addedInventoryItems", EmitDefaultValue = false)]
        public List<DestinyItemComponent> AddedInventoryItems { get; set; }

        /// <summary>
        /// Items that disappeared from the inventory possibly as a result of an action.
        /// </summary>
        [DataMember(Name = "removedInventoryItems", EmitDefaultValue = false)]
        public List<DestinyItemComponent> RemovedInventoryItems { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as InventoryChangedResponse);
        }

        public bool Equals(InventoryChangedResponse input)
        {
            if (input == null) return false;

            return
                (
                    AddedInventoryItems == input.AddedInventoryItems ||
                    (AddedInventoryItems != null && AddedInventoryItems.SequenceEqual(input.AddedInventoryItems))
                ) &&
                (
                    RemovedInventoryItems == input.RemovedInventoryItems ||
                    (RemovedInventoryItems != null && RemovedInventoryItems.SequenceEqual(input.RemovedInventoryItems))
                ) ;
        }
    }
}

