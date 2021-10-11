package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent struct {
	Data    map[int64]DestinyStringVariablesComponent `json:"data"`
	Privacy ComponentPrivacySetting                   `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
