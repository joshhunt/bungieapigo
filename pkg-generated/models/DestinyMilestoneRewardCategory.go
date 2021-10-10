package bungieAPI

// Represents a category of "summary" rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.
type DestinyMilestoneRewardCategory struct {

	// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
	RewardCategoryHash int `json:"rewardCategoryHash"`

	// The individual reward entries for this category, and their status.
	Entries []DestinyMilestoneRewardEntry `json:"entries"`
}
