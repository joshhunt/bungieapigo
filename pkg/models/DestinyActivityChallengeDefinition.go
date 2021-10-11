package bungieapigo

// Represents a reference to a Challenge, which for now is just an Objective.
type DestinyActivityChallengeDefinition struct {

	// The hash for the Objective that matches this challenge. Use it to look up the
	// DestinyObjectiveDefinition.
	ObjectiveHash int `json:"objectiveHash"`

	// The rewards as they're represented in the UI. Note that they generally link to "dummy" items
	// that give a summary of rewards rather than direct, real items themselves.
	// If the quantity is 0, don't show the quantity.
	DummyRewards []DestinyItemQuantity `json:"dummyRewards"`
}
