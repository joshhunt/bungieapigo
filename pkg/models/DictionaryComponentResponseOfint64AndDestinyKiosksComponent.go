package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyKiosksComponent struct {
	Data    map[int64]DestinyKiosksComponent `json:"data"`
	Privacy ComponentPrivacySetting          `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
