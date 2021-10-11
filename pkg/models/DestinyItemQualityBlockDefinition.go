package bungieapigo

// An item's "Quality" determines its calculated stats. The Level at which the item spawns is
// combined with its "qualityLevel" along with some additional calculations to determine the
// value of those stats.
// In Destiny 2, most items don't have default item levels and quality, making this property less
// useful: these apparently are almost always determined by the complex mechanisms of the Reward
// system rather than statically. They are still provided here in case they are still useful for
// people. This also contains some information about Infusion.
type DestinyItemQualityBlockDefinition struct {

	// The "base" defined level of an item. This is a list because, in theory, each Expansion could
	// define its own base level for an item.
	// In practice, not only was that never done in Destiny 1, but now this isn't even populated at all.
	// When it's not populated, the level at which it spawns has to be inferred by Reward information,
	// of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
	ItemLevels []int `json:"itemLevels"`

	// qualityLevel is used in combination with the item's level to calculate stats like Attack and
	// Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
	QualityLevel int `json:"qualityLevel"`

	// The string identifier for this item's "infusability", if any.
	// Items that match the same infusionCategoryName are allowed to infuse with each other.
	// DEPRECATED: Items can now have multiple infusion categories. Please use
	// infusionCategoryHashes instead.
	InfusionCategoryName string `json:"infusionCategoryName"`

	// The hash identifier for the infusion. It does not map to a Definition entity.
	// DEPRECATED: Items can now have multiple infusion categories. Please use
	// infusionCategoryHashes instead.
	InfusionCategoryHash int `json:"infusionCategoryHash"`

	// If any one of these hashes matches any value in another item's infusionCategoryHashes, the two
	// can infuse with each other.
	InfusionCategoryHashes []int `json:"infusionCategoryHashes"`

	// An item can refer to pre-set level requirements. They are defined in
	// DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the
	// appropriate definition.
	ProgressionLevelRequirementHash int `json:"progressionLevelRequirementHash"`

	// The latest version available for this item.
	CurrentVersion int `json:"currentVersion"`

	// The list of versions available for this item.
	Versions []DestinyItemVersionDefinition `json:"versions"`

	// Icon overlays to denote the item version and power cap status.
	DisplayVersionWatermarkIcons []string `json:"displayVersionWatermarkIcons"`
}
