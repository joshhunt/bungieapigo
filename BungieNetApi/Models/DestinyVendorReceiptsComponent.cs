using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// For now, this isn't used for much: it's a record of the recent refundable purchases that the user has made. In the future, it could be used for providing refunds/buyback via the API. Wouldn't that be fun?
    /// </summary>
    [DataContract]
    public class DestinyVendorReceiptsComponent
    {
        /// <summary>
        /// The receipts for refundable purchases made at a vendor.
        /// </summary>
        [DataMember(Name = "receipts", EmitDefaultValue = false)]
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
    }
}

