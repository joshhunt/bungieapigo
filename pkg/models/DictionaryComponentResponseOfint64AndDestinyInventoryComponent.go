package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyInventoryComponent struct {
	Data    map[int64]DestinyInventoryComponent `json:"data"`
	Privacy ComponentPrivacySetting             `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
