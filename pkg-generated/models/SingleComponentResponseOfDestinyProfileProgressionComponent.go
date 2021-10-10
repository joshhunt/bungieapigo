package bungieAPI

type SingleComponentResponseOfDestinyProfileProgressionComponent struct {

	// The set of progression-related information that applies at a Profile-wide level for your
	// Destiny experience. This differs from the Jimi Hendrix Experience because there's less
	// guitars on fire. Yet. #spoileralert?
	// This will include information such as Checklist info.
	Data DestinyProfileProgressionComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
