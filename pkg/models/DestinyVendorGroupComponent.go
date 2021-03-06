package bungieapigo

// This component returns references to all of the Vendors in the response, grouped by
// categorizations that Bungie has deemed to be interesting, in the order in which both the groups
// and the vendors within that group should be rendered.
type DestinyVendorGroupComponent struct {

	// The ordered list of groups being returned.
	Groups []DestinyVendorGroup `json:"groups"`
}
