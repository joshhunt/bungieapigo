package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent struct {
	Data    map[int64]DestinyItemSocketsComponent `json:"data"`
	Privacy ComponentPrivacySetting               `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
