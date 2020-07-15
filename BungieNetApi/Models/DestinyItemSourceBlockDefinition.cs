using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Data about an item's "sources": ways that the item can be obtained.
    /// </summary>
    [DataContract]
    public class DestinyItemSourceBlockDefinition
    {
        /// <summary>
        /// The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).
        /// </summary>
        [DataMember(Name = "sourceHashes", EmitDefaultValue = false)]
        public List<uint> SourceHashes { get; set; }

        /// <summary>
        /// A collection of details about the stats that were computed for the ways we found that the item could be spawned.
        /// </summary>
        [DataMember(Name = "sources", EmitDefaultValue = false)]
        public List<DestinyItemSourceDefinition> Sources { get; set; }

        /// <summary>
        /// If we found that this item is exclusive to a specific platform, this will be set to the BungieMembershipType enumeration that matches that platform.
        /// </summary>
        [DataMember(Name = "exclusive", EmitDefaultValue = false)]
        public BungieMembershipType Exclusive { get; set; }

        /// <summary>
        /// A denormalized reference back to vendors that potentially sell this item.
        /// </summary>
        [DataMember(Name = "vendorSources", EmitDefaultValue = false)]
        public List<DestinyItemVendorSourceReference> VendorSources { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSourceBlockDefinition);
        }

        public bool Equals(DestinyItemSourceBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    SourceHashes == input.SourceHashes ||
                    (SourceHashes != null && SourceHashes.Equals(input.SourceHashes))
                ) &&
                (
                    Sources == input.Sources ||
                    (Sources != null && Sources.Equals(input.Sources))
                ) &&
                (
                    Exclusive == input.Exclusive ||
                    (Exclusive != null && Exclusive.Equals(input.Exclusive))
                ) &&
                (
                    VendorSources == input.VendorSources ||
                    (VendorSources != null && VendorSources.Equals(input.VendorSources))
                ) ;
        }
    }
}

