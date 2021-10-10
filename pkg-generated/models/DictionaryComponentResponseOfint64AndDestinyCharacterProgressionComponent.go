package bungieAPI

type DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent struct {
	Data    map[int64]DestinyCharacterProgressionComponent `json:"data"`
	Privacy ComponentPrivacySetting                        `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
