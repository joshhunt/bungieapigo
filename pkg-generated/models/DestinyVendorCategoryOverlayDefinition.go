package bungieAPI

// The details of an overlay prompt to show to a user. They are all fairly self-explanatory localized strings that can be shown.
type DestinyVendorCategoryOverlayDefinition struct {
	ChoiceDescription string `json:"choiceDescription"`
	Description       string `json:"description"`
	Icon              string `json:"icon"`
	Title             string `json:"title"`

	// If this overlay has a currency item that it features, this is said featured item.
	CurrencyItemHash int `json:"currencyItemHash"`
}
