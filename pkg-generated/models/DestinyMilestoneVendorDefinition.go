package bungieAPI

// If the Milestone or a component has vendors whose inventories could/should be displayed that are relevant to it, this will return the vendor in question.
// It also contains information we need to determine whether that vendor is actually relevant at the moment, given the user's current state.
type DestinyMilestoneVendorDefinition struct {

	// The hash of the vendor whose wares should be shown as associated with the Milestone.
	VendorHash int `json:"vendorHash"`
}
