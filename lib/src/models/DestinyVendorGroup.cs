using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Represents a specific group of vendors that can be rendered in the recommended order.
	/// How do we figure out this order? It&#39;s a long story, and will likely get more complicated over time.
	[DataContract]
	public class DestinyVendorGroup{

		[DataMember(Name="vendorGroupHash", EmitDefaultValue=false)]
		public uint VendorGroupHash { get; set; }

		/// <summary>
		/// The ordered list of vendors within a particular group.
		/// </summary>
		[DataMember(Name="vendorHashes", EmitDefaultValue=false)]
		public List<uint> VendorHashes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorGroup);
        }

		public bool Equals(DestinyVendorGroup input)
		{
			if (input == null) return false;

			return
				(
                    VendorGroupHash == input.VendorGroupHash ||
                    (VendorGroupHash != null && VendorGroupHash.Equals(input.VendorGroupHash))
                ) &&
				(
                    VendorHashes == input.VendorHashes ||
                    (VendorHashes != null && VendorHashes.Equals(input.VendorHashes))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.VendorGroupHash.GetHashCode();
				hashCode = hashCode * 59 + this.VendorHashes.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

