using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyVendorGroupReference
    {
        /// <summary>
        /// The DestinyVendorGroupDefinition to which this Vendor can belong.
        /// </summary>
        [DataMember(Name = "vendorGroupHash", EmitDefaultValue = false)]
        public uint VendorGroupHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorGroupReference);
        }

        public bool Equals(DestinyVendorGroupReference input)
        {
            if (input == null) return false;

            return
                (
                    VendorGroupHash == input.VendorGroupHash ||
                    (VendorGroupHash.Equals(input.VendorGroupHash))
                ) ;
        }
    }
}

