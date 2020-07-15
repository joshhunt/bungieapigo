using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// This component contains essential&#x2F;summary information about the vendor.
	[DataContract]
	public class DestinyVendorComponent{

		/// <summary>
		/// If True, you can purchase from the Vendor.
		/// </summary>
		[DataMember(Name="canPurchase", EmitDefaultValue=false)]
		public bool CanPurchase { get; set; }

		/// <summary>
		/// If the Vendor has a related Reputation, this is the Progression data that represents the character's Reputation level with this Vendor.
		/// </summary>
		[DataMember(Name="progression", EmitDefaultValue=false)]
		public DestinyProgression Progression { get; set; }

		/// <summary>
		/// An index into the vendor definition's "locations" property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it's your bag honey)
		/// </summary>
		[DataMember(Name="vendorLocationIndex", EmitDefaultValue=false)]
		public long VendorLocationIndex { get; set; }

		/// <summary>
		/// If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that's pretty sweeet. It's a whole 32 bit integer.
		/// </summary>
		[DataMember(Name="seasonalRank", EmitDefaultValue=false)]
		public long SeasonalRank { get; set; }

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
            return this.Equals(input as DestinyVendorComponent);
        }

		public bool Equals(DestinyVendorComponent input)
		{
			if (input == null) return false;

			return
				(
                    CanPurchase == input.CanPurchase ||
                    (CanPurchase != null && CanPurchase.Equals(input.CanPurchase))
                ) &&
				(
                    Progression == input.Progression ||
                    (Progression != null && Progression.Equals(input.Progression))
                ) &&
				(
                    VendorLocationIndex == input.VendorLocationIndex ||
                    (VendorLocationIndex != null && VendorLocationIndex.Equals(input.VendorLocationIndex))
                ) &&
				(
                    SeasonalRank == input.SeasonalRank ||
                    (SeasonalRank != null && SeasonalRank.Equals(input.SeasonalRank))
                ) &&
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
				hashCode = hashCode * 59 + this.CanPurchase.GetHashCode();
				hashCode = hashCode * 59 + this.Progression.GetHashCode();
				hashCode = hashCode * 59 + this.VendorLocationIndex.GetHashCode();
				hashCode = hashCode * 59 + this.SeasonalRank.GetHashCode();
				hashCode = hashCode * 59 + this.VendorHash.GetHashCode();
				hashCode = hashCode * 59 + this.NextRefreshDate.GetHashCode();
				hashCode = hashCode * 59 + this.Enabled.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

