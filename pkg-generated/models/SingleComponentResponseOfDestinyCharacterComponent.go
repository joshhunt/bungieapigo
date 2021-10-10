package bungieAPI

type SingleComponentResponseOfDestinyCharacterComponent struct {

	// This component contains base properties of the character. You'll probably want to always request this component, but hey you do you.
	Data    DestinyCharacterComponent `json:"data"`
	Privacy ComponentPrivacySetting   `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
