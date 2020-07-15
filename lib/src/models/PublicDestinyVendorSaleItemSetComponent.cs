using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class PublicDestinyVendorSaleItemSetComponent{

		[DataMember(Name="saleItems", EmitDefaultValue=false)]
		public Map<String, DestinyPublicVendorSaleItemComponent> SaleItems { get; set; }


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
                    (SaleItems != null && SaleItems.Equals(input.SaleItems))
                ) ;
		}
	}
}

