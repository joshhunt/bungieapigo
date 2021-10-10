package bungieAPI

// Milestones can have associated activities which provide additional information about the context, challenges, modifiers, state etc... related to this Milestone.
// Information we need to be able to return that data is defined here, along with Tier data to establish a relationship between a conceptual Activity and its difficulty levels and variants.
type DestinyMilestoneActivityDefinition struct {

	// The "Conceptual" activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.
	// If you care about the specific difficulty modes and variations, use the activities under "Variants".
	ConceptualActivityHash int `json:"conceptualActivityHash"`

	// A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.
	// Even if there is only a single variant, the details for these are represented within as a variant definition.
	// It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.
	// If a Milestone could ever split the variants' active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.
	Variants map[int]DestinyMilestoneActivityVariantDefinition `json:"variants"`
}
