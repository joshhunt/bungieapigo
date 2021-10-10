package bungieAPI

type SingleComponentResponseOfDestinyCharacterActivitiesComponent struct {

	// This component holds activity data for a character. It will tell you about the character's
	// current activity status, as well as activities that are available to the user.
	Data DestinyCharacterActivitiesComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
