package bungieapigo

type DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent struct {
	Data    map[int]DestinyItemObjectivesComponent `json:"data"`
	Privacy ComponentPrivacySetting                `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
