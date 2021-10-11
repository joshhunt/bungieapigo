package bungieapigo

type SingleComponentResponseOfDestinyProfileComponent struct {

	// The most essential summary information about a Profile (in Destiny 1, we called these
	// "Accounts").
	Data DestinyProfileComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
