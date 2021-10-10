package bungieAPI

type DestinyArtifactTierDefinition struct {

	// An identifier, unique within the Artifact, for this specific tier.
	TierHash int `json:"tierHash"`

	// The human readable title of this tier, if any.
	DisplayTitle string `json:"displayTitle"`

	// A string representing the localized minimum requirement text for this Tier, if any.
	ProgressRequirementMessage string `json:"progressRequirementMessage"`

	// The items that can be earned within this tier.
	Items []DestinyArtifactTierItemDefinition `json:"items"`

	// The minimum number of "unlock points" that you must have used before you can unlock items from
	// this tier.
	MinimumUnlockPointsUsedRequirement int `json:"minimumUnlockPointsUsedRequirement"`
}
