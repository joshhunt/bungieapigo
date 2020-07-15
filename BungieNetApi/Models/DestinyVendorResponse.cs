using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// A response containing all of the components for a vendor.
    /// </summary>
    [DataContract]
    public class DestinyVendorResponse
    {
        /// <summary>
        /// The base properties of the vendor.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Vendors
        /// </summary>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorComponent Vendor { get; set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: VendorCategories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorCategoriesComponent Categories { get; set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: VendorSales
        /// </summary>
        [DataMember(Name = "sales", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales { get; set; }

        /// <summary>
        /// Item components, keyed by the vendorItemIndex of the active sale items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        [DataMember(Name = "itemComponents", EmitDefaultValue = false)]
        public DestinyItemComponentSetOfint32 ItemComponents { get; set; }

        /// <summary>
        /// A "lookup" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CurrencyLookups
        /// </summary>
        [DataMember(Name = "currencyLookups", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorResponse);
        }

        public bool Equals(DestinyVendorResponse input)
        {
            if (input == null) return false;

            return
                (
                    Vendor == input.Vendor ||
                    (Vendor != null && Vendor.Equals(input.Vendor))
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

