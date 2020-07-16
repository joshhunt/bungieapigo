using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// A "Location" is a sort of shortcut for referring to a specific combination of Activity, Destination, Place, and even Bubble or NavPoint within a space.
    /// </summary>
    /// <summary>
    /// Most of this data isn't intrinsically useful to us, but Objectives refer to locations, and through that we can at least infer the Activity, Destination, and Place being referred to by the Objective.
    /// </summary>
    [DataContract]
    public class DestinyLocationDefinition
    {
        /// <summary>
        /// If the location has a Vendor on it, this is the hash identifier for that Vendor. Look them up with DestinyVendorDefinition.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }

        /// <summary>
        /// A Location may refer to different specific spots in the world based on the world's current state. This is a list of those potential spots, and the data we can use at runtime to determine which one of the spots is the currently valid one.
        /// </summary>
        [DataMember(Name = "locationReleases", EmitDefaultValue = false)]
        public List<DestinyLocationReleaseDefinition> LocationReleases { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
        /// </summary>
        /// <summary>
        /// When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        [DataMember(Name = "redacted", EmitDefaultValue = false)]
        public bool Redacted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLocationDefinition);
        }

        public bool Equals(DestinyLocationDefinition input)
        {
            if (input == null) return false;

            return
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
                (
                    LocationReleases == input.LocationReleases ||
                    (LocationReleases != null && LocationReleases.Equals(input.LocationReleases))
                ) &&
                (
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
                (
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
                (
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
        }
    }
}

