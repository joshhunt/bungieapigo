package bungieAPI

type SingleComponentResponseOfDestinyStringVariablesComponent struct {
	Data    DestinyStringVariablesComponent `json:"data"`
	Privacy ComponentPrivacySetting         `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
