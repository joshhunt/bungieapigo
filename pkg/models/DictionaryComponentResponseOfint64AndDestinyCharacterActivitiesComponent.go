package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent struct {
	Data    map[int64]DestinyCharacterActivitiesComponent `json:"data"`
	Privacy ComponentPrivacySetting                       `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
