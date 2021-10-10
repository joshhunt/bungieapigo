package bungieAPI

type DictionaryComponentResponseOfint32AndDestinyItemStatsComponent struct {
	Data    map[int]DestinyItemStatsComponent `json:"data"`
	Privacy ComponentPrivacySetting           `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
