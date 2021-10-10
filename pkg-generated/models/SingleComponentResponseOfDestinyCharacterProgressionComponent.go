package bungieAPI

type SingleComponentResponseOfDestinyCharacterProgressionComponent struct {

	// This component returns anything that could be considered "Progression" on a user: data where
	// the user is gaining levels, reputation, completions, rewards, etc...
	Data DestinyCharacterProgressionComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
