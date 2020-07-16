using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// These definitions represent faction vendors at different points in the game.
    /// </summary>
    /// <summary>
    /// A single faction may contain multiple vendors, or the same vendor available at two different locations.
    /// </summary>
    [DataContract]
    public class DestinyFactionVendorDefinition
    {
        /// <summary>
        /// The faction vendor hash.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }

        /// <summary>
        /// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
        /// </summary>
        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public uint DestinationHash { get; set; }

        /// <summary>
        /// The relative path to the background image representing this Vendor at this location, for use in a banner.
        /// </summary>
        [DataMember(Name = "backgroundImagePath", EmitDefaultValue = false)]
        public string BackgroundImagePath { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyFactionVendorDefinition);
        }

        public bool Equals(DestinyFactionVendorDefinition input)
        {
            if (input == null) return false;

            return
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
                (
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) &&
                (
                    BackgroundImagePath == input.BackgroundImagePath ||
                    (BackgroundImagePath != null && BackgroundImagePath.Equals(input.BackgroundImagePath))
                ) ;
        }
    }
}

