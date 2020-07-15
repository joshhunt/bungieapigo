using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent{

		[DataMember(Name="saleItems", EmitDefaultValue=false)]
		public Dictionary<string, DestinyVendorSaleItemComponent> SaleItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent);
        }

		public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent input)
		{
			if (input == null) return false;

			return
				(
                    SaleItems == input.SaleItems ||
                    (SaleItems != null && SaleItems.Equals(input.SaleItems))
                ) ;
		}
	}
}

