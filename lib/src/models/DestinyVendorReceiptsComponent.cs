using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// For now, this isn&#39;t used for much: it&#39;s a record of the recent refundable purchases that the user has made. In the future, it could be used for providing refunds&#x2F;buyback via the API. Wouldn&#39;t that be fun?
	[DataContract]
	public class DestinyVendorReceiptsComponent{

		/// <summary>
		/// The receipts for refundable purchases made at a vendor.
		/// </summary>
		[DataMember(Name="receipts", EmitDefaultValue=false)]
		public List<DestinyVendorReceipt> Receipts { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorReceiptsComponent);
        }

		public bool Equals(DestinyVendorReceiptsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Receipts == input.Receipts ||
                    (Receipts != null && Receipts.Equals(input.Receipts))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Receipts.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

