package bungieAPI

type DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent struct {
	Data    map[int]DestinyItemPlugComponent `json:"data"`
	Privacy ComponentPrivacySetting          `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
