package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemStatsComponent struct {
	Data    map[int64]DestinyItemStatsComponent `json:"data"`
	Privacy ComponentPrivacySetting             `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
