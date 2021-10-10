package bungieAPI

type SingleComponentResponseOfDestinyPlatformSilverComponent struct {
	Data    DestinyPlatformSilverComponent `json:"data"`
	Privacy ComponentPrivacySetting        `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
