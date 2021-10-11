package bungieapigo

// Compare this sackType to the sack identifier in the
// DestinyInventoryItemDefinition.vendorSackType property of items. If they match, show
// this sack with this interaction.
type DestinyVendorInteractionSackEntryDefinition struct {
	SackType int `json:"sackType"`
}
