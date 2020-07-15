using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Part of our dynamic, localized Milestone content is arbitrary categories of items. These are built in our content management system, and thus aren't the same as programmatically generated rewards.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneContentItemCategory
    {
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "itemHashes", EmitDefaultValue = false)]
        public List<uint> ItemHashes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneContentItemCategory);
        }

        public bool Equals(DestinyMilestoneContentItemCategory input)
        {
            if (input == null) return false;

            return
                (
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
                (
                    ItemHashes == input.ItemHashes ||
                    (ItemHashes != null && ItemHashes.Equals(input.ItemHashes))
                ) ;
        }
    }
}

