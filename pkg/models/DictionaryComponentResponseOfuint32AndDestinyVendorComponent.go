package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyVendorComponent struct {
	Data    map[int]DestinyVendorComponent `json:"data"`
	Privacy ComponentPrivacySetting        `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
