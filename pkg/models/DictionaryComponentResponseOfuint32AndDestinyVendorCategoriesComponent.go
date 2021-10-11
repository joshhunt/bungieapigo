package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent struct {
	Data    map[int]DestinyVendorCategoriesComponent `json:"data"`
	Privacy ComponentPrivacySetting                  `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
