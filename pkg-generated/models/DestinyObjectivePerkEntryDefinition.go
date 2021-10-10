package bungieAPI

// Defines the conditions under which an intrinsic perk is applied while participating in an
// Objective.
// These perks will generally not be benefit-granting perks, but rather a perk that modifies
// gameplay in some interesting way.
type DestinyObjectivePerkEntryDefinition struct {

	// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the
	// character.
	PerkHash int `json:"perkHash"`

	// An enumeration indicating whether it will be applied as long as the Objective is active, when
	// it's completed, or until it's completed.
	Style DestinyObjectiveGrantStyle `json:"style"`
}
