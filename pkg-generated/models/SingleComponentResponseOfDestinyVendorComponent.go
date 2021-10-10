package bungieAPI

type SingleComponentResponseOfDestinyVendorComponent struct {

	// This component contains essential/summary information about the vendor.
	Data DestinyVendorComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
