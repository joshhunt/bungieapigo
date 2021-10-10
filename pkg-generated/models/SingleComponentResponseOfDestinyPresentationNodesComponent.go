package bungieAPI

type SingleComponentResponseOfDestinyPresentationNodesComponent struct {
	Data    DestinyPresentationNodesComponent `json:"data"`
	Privacy ComponentPrivacySetting           `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
