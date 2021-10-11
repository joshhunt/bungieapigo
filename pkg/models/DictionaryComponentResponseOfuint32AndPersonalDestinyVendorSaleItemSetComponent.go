package bungieapigo

type DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent struct {
	Data    map[int]PersonalDestinyVendorSaleItemSetComponent `json:"data"`
	Privacy ComponentPrivacySetting                           `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
