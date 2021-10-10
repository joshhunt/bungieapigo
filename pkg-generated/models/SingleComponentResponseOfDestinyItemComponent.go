package bungieAPI

type SingleComponentResponseOfDestinyItemComponent struct {

	// The base item component, filled with properties that are generally useful to know in any item request or that don't feel worthwhile to put in their own component.
	Data    DestinyItemComponent    `json:"data"`
	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
