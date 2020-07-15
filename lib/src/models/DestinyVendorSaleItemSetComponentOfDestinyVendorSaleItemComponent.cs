using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent{

		[DataMember(Name="saleItems", EmitDefaultValue=false)]
		public Map<String, DestinyVendorSaleItemComponent> SaleItems { get; set; }


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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.SaleItems.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

