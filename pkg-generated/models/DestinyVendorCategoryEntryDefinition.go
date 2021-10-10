package bungieAPI

// This is the definition for a single Vendor Category, into which Sale Items are grouped.
type DestinyVendorCategoryEntryDefinition struct {

	// The index of the category in the original category definitions for the vendor.
	CategoryIndex int `json:"categoryIndex"`

	// Used in sorting items in vendors... but there's a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.
	SortValue int `json:"sortValue"`

	// The hashed identifier for the category.
	CategoryHash int `json:"categoryHash"`

	// The amount of items that will be available when this category is shown.
	QuantityAvailable int `json:"quantityAvailable"`

	// If items aren't up for sale in this category, should we still show them (greyed out)?
	ShowUnavailableItems bool `json:"showUnavailableItems"`

	// If you don't have the currency required to buy items from this category, should the items be hidden?
	HideIfNoCurrency bool `json:"hideIfNoCurrency"`

	// True if this category doesn't allow purchases.
	HideFromRegularPurchase bool `json:"hideFromRegularPurchase"`

	// The localized string for making purchases from this category, if it is different from the vendor's string for purchasing.
	BuyStringOverride string `json:"buyStringOverride"`

	// If the category is disabled, this is the localized description to show.
	DisabledDescription string `json:"disabledDescription"`

	// The localized title of the category.
	DisplayTitle string `json:"displayTitle"`

	// If this category has an overlay prompt that should appear, this contains the details of that prompt.
	Overlay DestinyVendorCategoryOverlayDefinition `json:"overlay"`

	// A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.
	VendorItemIndexes []int `json:"vendorItemIndexes"`

	// Sometimes a category isn't actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.
	IsPreview bool `json:"isPreview"`

	// If true, this category only displays items: you can't purchase anything in them.
	IsDisplayOnly                bool `json:"isDisplayOnly"`
	ResetIntervalMinutesOverride int  `json:"resetIntervalMinutesOverride"`
	ResetOffsetMinutesOverride   int  `json:"resetOffsetMinutesOverride"`
}
