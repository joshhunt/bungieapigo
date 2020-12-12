using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class PublicDestinyVendorSaleItemSetComponent
    {
        [DataMember(Name = "saleItems", EmitDefaultValue = false)]
        public Dictionary<string, DestinyPublicVendorSaleItemComponent> SaleItems { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as PublicDestinyVendorSaleItemSetComponent);
        }

        public bool Equals(PublicDestinyVendorSaleItemSetComponent input)
        {
            if (input == null) return false;

            return
                (
                    SaleItems == input.SaleItems ||
                    (SaleItems != null && SaleItems.SequenceEqual(input.SaleItems))
                ) ;
        }
    }
}

