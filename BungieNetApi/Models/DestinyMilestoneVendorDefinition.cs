using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// If the Milestone or a component has vendors whose inventories could/should be displayed that are relevant to it, this will return the vendor in question. 
    /// </summary>
    /// <summary>
    /// It also contains information we need to determine whether that vendor is actually relevant at the moment, given the user's current state.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneVendorDefinition
    {
        /// <summary>
        /// The hash of the vendor whose wares should be shown as associated with the Milestone.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneVendorDefinition);
        }

        public bool Equals(DestinyMilestoneVendorDefinition input)
        {
            if (input == null) return false;

            return
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash.Equals(input.VendorHash))
                ) ;
        }
    }
}

