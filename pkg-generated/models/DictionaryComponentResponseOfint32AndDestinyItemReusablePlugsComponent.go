package bungieAPI

type DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent struct {
	Data    map[int]DestinyItemReusablePlugsComponent `json:"data"`
	Privacy ComponentPrivacySetting                   `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
