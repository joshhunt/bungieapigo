package bungieapigo

// An intrinsic perk on an item, and the requirements for it to be activated.
type DestinyItemPerkEntryDefinition struct {

	// If this perk is not active, this is the string to show for why it's not providing its benefits.
	RequirementDisplayString string `json:"requirementDisplayString"`

	// A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
	PerkHash int `json:"perkHash"`

	// Indicates whether this perk should be shown, or if it should be shown disabled.
	PerkVisibility ItemPerkVisibility `json:"perkVisibility"`
}
