using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// A response containing all of the components for all requested vendors.
	[DataContract]
	public class DestinyVendorsResponse{

		/// <summary>
		/// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: Vendors
		/// </summary>
		[DataMember(Name="vendorGroups", EmitDefaultValue=false)]
		public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

		/// <summary>
		/// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: Vendors
		/// </summary>
		[DataMember(Name="vendors", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors { get; set; }

		/// <summary>
		/// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: VendorCategories
		/// </summary>
		[DataMember(Name="categories", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }

		/// <summary>
		/// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.
		/// </summary>
		/// <summary>
		/// Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor's definition.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: VendorSales
		/// </summary>
		[DataMember(Name="sales", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales { get; set; }

		/// <summary>
		/// The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.
		/// </summary>
		/// <summary>
		/// The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor.
		/// </summary>
		[DataMember(Name="itemComponents", EmitDefaultValue=false)]
		public Map<String, DestinyItemComponentSetOfint32> ItemComponents { get; set; }

		/// <summary>
		/// A "lookup" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: CurrencyLookups
		/// </summary>
		[DataMember(Name="currencyLookups", EmitDefaultValue=false)]
		public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorsResponse);
        }

		public bool Equals(DestinyVendorsResponse input)
		{
			if (input == null) return false;

			return
				(
                    VendorGroups == input.VendorGroups ||
                    (VendorGroups != null && VendorGroups.Equals(input.VendorGroups))
                ) &&
				(
                    Vendors == input.Vendors ||
                    (Vendors != null && Vendors.Equals(input.Vendors))
                ) &&
				(
                    Categories == input.Categories ||
                    (Categories != null && Categories.Equals(input.Categories))
                ) &&
				(
                    Sales == input.Sales ||
                    (Sales != null && Sales.Equals(input.Sales))
                ) &&
				(
                    ItemComponents == input.ItemComponents ||
                    (ItemComponents != null && ItemComponents.Equals(input.ItemComponents))
                ) &&
				(
                    CurrencyLookups == input.CurrencyLookups ||
                    (CurrencyLookups != null && CurrencyLookups.Equals(input.CurrencyLookups))
                ) ;
		}
	}
}

