package bungieapigo

// Represents the public-facing status of an activity: any data about what is currently active in
// the Activity, regardless of an individual character's progress in it.
type DestinyPublicActivityStatus struct {

	// Active Challenges for the activity, if any - represented as hashes for
	// DestinyObjectiveDefinitions.
	ChallengeObjectiveHashes []int `json:"challengeObjectiveHashes"`

	// The active modifiers on this activity, if any - represented as hashes for
	// DestinyActivityModifierDefinitions.
	ModifierHashes []int `json:"modifierHashes"`

	// If the activity itself provides any specific "mock" rewards, this will be the items and their
	// quantity.
	// Why "mock", you ask? Because these are the rewards as they are represented in the tooltip of the
	// Activity.
	// These are often pointers to fake items that look good in a tooltip, but represent an abstract
	// concept of what you will get for a reward rather than the specific items you may obtain.
	RewardTooltipItems []DestinyItemQuantity `json:"rewardTooltipItems"`
}
