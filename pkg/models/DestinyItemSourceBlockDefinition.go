package bungieapigo

// Data about an item's "sources": ways that the item can be obtained.
type DestinyItemSourceBlockDefinition struct {

	// The list of hash identifiers for Reward Sources that hint where the item can be found
	// (DestinyRewardSourceDefinition).
	SourceHashes []int `json:"sourceHashes"`

	// A collection of details about the stats that were computed for the ways we found that the item
	// could be spawned.
	Sources []DestinyItemSourceDefinition `json:"sources"`

	// If we found that this item is exclusive to a specific platform, this will be set to the
	// BungieMembershipType enumeration that matches that platform.
	Exclusive BungieMembershipType `json:"exclusive"`

	// A denormalized reference back to vendors that potentially sell this item.
	VendorSources []DestinyItemVendorSourceReference `json:"vendorSources"`
}
