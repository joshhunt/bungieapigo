package bungieapigo

type SingleComponentResponseOfDestinyMetricsComponent struct {
	Data    DestinyMetricsComponent `json:"data"`
	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
