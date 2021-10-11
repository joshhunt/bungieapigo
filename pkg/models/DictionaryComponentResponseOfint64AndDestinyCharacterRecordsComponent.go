package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent struct {
	Data    map[int64]DestinyCharacterRecordsComponent `json:"data"`
	Privacy ComponentPrivacySetting                    `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
