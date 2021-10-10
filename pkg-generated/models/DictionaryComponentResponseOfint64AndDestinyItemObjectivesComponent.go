package bungieAPI

type DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent struct {
	Data    map[int64]DestinyItemObjectivesComponent `json:"data"`
	Privacy ComponentPrivacySetting                  `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
