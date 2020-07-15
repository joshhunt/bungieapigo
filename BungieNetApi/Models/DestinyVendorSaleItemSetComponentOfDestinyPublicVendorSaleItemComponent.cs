using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent{

		[DataMember(Name="saleItems", EmitDefaultValue=false)]
		public Map<String, DestinyPublicVendorSaleItemComponent> SaleItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent);
        }

		public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyPublicVendorSaleItemComponent input)
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

