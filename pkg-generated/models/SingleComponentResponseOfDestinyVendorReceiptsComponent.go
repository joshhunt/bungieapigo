package bungieAPI

type SingleComponentResponseOfDestinyVendorReceiptsComponent struct {

	// For now, this isn't used for much: it's a record of the recent refundable purchases that the user
	// has made. In the future, it could be used for providing refunds/buyback via the API. Wouldn't
	// that be fun?
	Data DestinyVendorReceiptsComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
