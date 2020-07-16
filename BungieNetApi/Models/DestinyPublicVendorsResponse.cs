using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// A response containing all valid components for the public Vendors endpoint.
    /// </summary>
    /// <summary>
    ///  It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.
    /// </summary>
    /// <summary>
    ///  If you want any of the other data - item details, whether or not you can buy it, etc... you'll have to call in the context of a character. I know, sad but true.
    /// </summary>
    [DataContract]
    public class DestinyPublicVendorsResponse
    {
        /// <summary>
        /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Vendors
        /// </summary>
        [DataMember(Name = "vendorGroups", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

        /// <summary>
        /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Vendors
        /// </summary>
        [DataMember(Name = "vendors", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors { get; set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: VendorCategories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
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
        [DataMember(Name = "sales", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicVendorsResponse);
        }

        public bool Equals(DestinyPublicVendorsResponse input)
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
                ) ;
        }
    }
}

