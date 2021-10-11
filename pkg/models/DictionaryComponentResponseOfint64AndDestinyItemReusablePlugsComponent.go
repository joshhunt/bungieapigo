package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent struct {
	Data    map[int64]DestinyItemReusablePlugsComponent `json:"data"`
	Privacy ComponentPrivacySetting                     `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
