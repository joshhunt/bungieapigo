package bungieAPI

type DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent struct {
	Data    map[int]DestinyItemPerksComponent `json:"data"`
	Privacy ComponentPrivacySetting           `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
