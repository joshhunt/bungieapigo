package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyCharacterComponent struct {
	Data    map[int64]DestinyCharacterComponent `json:"data"`
	Privacy ComponentPrivacySetting             `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
