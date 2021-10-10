package bungieAPI

// Bare minimum summary information for an item, for the sake of 3D rendering the item.
type DestinyItemPeerView struct {

	// The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.
	ItemHash int `json:"itemHash"`

	// The list of dyes that have been applied to this item.
	Dyes []DyeReference `json:"dyes"`
}
