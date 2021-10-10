package bungieAPI

type SingleComponentResponseOfDestinyProfileCollectiblesComponent struct {
	Data    DestinyProfileCollectiblesComponent `json:"data"`
	Privacy ComponentPrivacySetting             `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
