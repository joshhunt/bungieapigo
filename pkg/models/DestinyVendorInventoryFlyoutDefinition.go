package bungieapigo

// The definition for an "inventory flyout": a UI screen where we show you part of an otherwise
// hidden vendor inventory: like the Vault inventory buckets.
type DestinyVendorInventoryFlyoutDefinition struct {

	// If the flyout is locked, this is the reason why.
	LockedDescription string `json:"lockedDescription"`

	// The title and other common properties of the flyout.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// A list of inventory buckets and other metadata to show on the screen.
	Buckets []DestinyVendorInventoryFlyoutBucketDefinition `json:"buckets"`

	// An identifier for the flyout, in case anything else needs to refer to them.
	FlyoutId int `json:"flyoutId"`

	// If this is true, don't show any of the glistening "this is a new item" UI elements, like we show on
	// the inventory items themselves in in-game UI.
	SuppressNewness bool `json:"suppressNewness"`

	// If this flyout is meant to show you the contents of the player's equipment slot, this is the slot
	// to show.
	EquipmentSlotHash int `json:"equipmentSlotHash"`
}
