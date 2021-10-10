package bungieAPI

type DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent struct {
	Data    map[int]DestinyVendorSaleItemComponent `json:"data"`
	Privacy ComponentPrivacySetting                `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
