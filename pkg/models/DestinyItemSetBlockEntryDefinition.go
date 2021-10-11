package bungieapigo

// Defines a particular entry in an ItemSet (AKA a particular Quest Step in a Quest)
type DestinyItemSetBlockEntryDefinition struct {

	// Used for tracking which step a user reached. These values will be populated in the user's
	// internal state, which we expose externally as a more usable DestinyQuestStatus object. If
	// this item has been obtained, this value will be set in trackingUnlockValueHash.
	TrackingValue int `json:"trackingValue"`

	// This is the hash identifier for a DestinyInventoryItemDefinition representing this quest
	// step.
	ItemHash int `json:"itemHash"`
}
