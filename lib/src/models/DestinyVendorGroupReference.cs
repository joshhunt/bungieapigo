using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyVendorGroupReference{

		/// <summary>
		/// The DestinyVendorGroupDefinition to which this Vendor can belong.
		/// </summary>
		[DataMember(Name="vendorGroupHash", EmitDefaultValue=false)]
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
                    (VendorGroupHash != null && VendorGroupHash.Equals(input.VendorGroupHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.VendorGroupHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

