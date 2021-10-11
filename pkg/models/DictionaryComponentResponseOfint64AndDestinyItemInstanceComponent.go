package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent struct {
	Data    map[int64]DestinyItemInstanceComponent `json:"data"`
	Privacy ComponentPrivacySetting                `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
