package bungieAPI

type SingleComponentResponseOfDestinyVendorGroupComponent struct {

	// This component returns references to all of the Vendors in the response, grouped by categorizations that Bungie has deemed to be interesting, in the order in which both the groups and the vendors within that group should be rendered.
	Data    DestinyVendorGroupComponent `json:"data"`
	Privacy ComponentPrivacySetting     `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
