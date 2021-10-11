package bungieapigo

// A response containing all of the components for a vendor.
type DestinyVendorResponse struct {

	// The base properties of the vendor.
	// COMPONENT TYPE: Vendors
	Vendor SingleComponentResponseOfDestinyVendorComponent `json:"vendor"`

	// Categories that the vendor has available, and references to the sales therein.
	// COMPONENT TYPE: VendorCategories
	Categories SingleComponentResponseOfDestinyVendorCategoriesComponent `json:"categories"`

	// Sales, keyed by the vendorItemIndex of the item being sold.
	// COMPONENT TYPE: VendorSales
	Sales DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent `json:"sales"`

	// Item components, keyed by the vendorItemIndex of the active sale items.
	// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
	ItemComponents DestinyItemComponentSetOfint32 `json:"itemComponents"`

	// A "lookup" convenience component that can be used to quickly check if the character has access
	// to items that can be used for purchasing.
	// COMPONENT TYPE: CurrencyLookups
	CurrencyLookups SingleComponentResponseOfDestinyCurrenciesComponent `json:"currencyLookups"`

	// A map of string variable values by hash for this character context.
	// COMPONENT TYPE: StringVariables
	StringVariables SingleComponentResponseOfDestinyStringVariablesComponent `json:"stringVariables"`
}
