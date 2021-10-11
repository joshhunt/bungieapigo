package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent struct {
	Data    map[int64]DestinyItemPlugObjectivesComponent `json:"data"`
	Privacy ComponentPrivacySetting                      `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
