using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// This component contains essential&#x2F;summary information about the vendor from the perspective of a character-agnostic view.
	[DataContract]
	public class DestinyPublicVendorComponent{

		/// <summary>
		/// The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.
		/// </summary>
		[DataMember(Name="vendorHash", EmitDefaultValue=false)]
		public uint VendorHash { get; set; }

		/// <summary>
		/// The date when this vendor's inventory will next rotate/refresh.
		/// </summary>
		/// <summary>
		/// Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor's available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.
		/// </summary>
		/// <summary>
		/// Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.
		/// </summary>
		[DataMember(Name="nextRefreshDate", EmitDefaultValue=false)]
		public string NextRefreshDate { get; set; }

		/// <summary>
		/// If True, the Vendor is currently accessible. 
		/// </summary>
		/// <summary>
		/// If False, they may not actually be visible in the world at the moment.
		/// </summary>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicVendorComponent);
        }

		public bool Equals(DestinyPublicVendorComponent input)
		{
			if (input == null) return false;

			return
				(
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
				(
                    NextRefreshDate == input.NextRefreshDate ||
                    (NextRefreshDate != null && NextRefreshDate.Equals(input.NextRefreshDate))
                ) &&
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.VendorHash.GetHashCode();
				hashCode = hashCode * 59 + this.NextRefreshDate.GetHashCode();
				hashCode = hashCode * 59 + this.Enabled.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

