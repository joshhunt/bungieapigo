package bungieAPI

// The action that happens when the user attempts to refund an item.
type DestinyVendorItemRefundPolicy int

const (
	DestinyVendorItemRefundPolicyNotRefundable  = 0
	DestinyVendorItemRefundPolicyDeletesItem    = 1
	DestinyVendorItemRefundPolicyRevokesLicense = 2
)
