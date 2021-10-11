package bungieapigo

type SingleComponentResponseOfDestinyItemReusablePlugsComponent struct {
	Data    DestinyItemReusablePlugsComponent `json:"data"`
	Privacy ComponentPrivacySetting           `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
