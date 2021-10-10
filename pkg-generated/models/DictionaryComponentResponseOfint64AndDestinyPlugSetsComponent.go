package bungieAPI

type DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent struct {
	Data    map[int64]DestinyPlugSetsComponent `json:"data"`
	Privacy ComponentPrivacySetting            `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
