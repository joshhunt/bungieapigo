package bungieAPI

type DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent struct {
	Data    map[int64]DestinyCollectiblesComponent `json:"data"`
	Privacy ComponentPrivacySetting                `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
