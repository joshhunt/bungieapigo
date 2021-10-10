package bungieAPI

type DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent struct {
	Data    map[int]PublicDestinyVendorSaleItemSetComponent `json:"data"`
	Privacy ComponentPrivacySetting                         `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
