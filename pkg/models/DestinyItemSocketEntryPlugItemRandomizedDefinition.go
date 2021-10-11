package bungieapigo

type DestinyItemSocketEntryPlugItemRandomizedDefinition struct {

	// Indicates if the plug can be rolled on the current version of the item. For example, older
	// versions of weapons may have plug rolls that are no longer possible on the current versions.
	CurrentlyCanRoll bool `json:"currentlyCanRoll"`

	// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be
	// inserted.
	PlugItemHash int `json:"plugItemHash"`
}
