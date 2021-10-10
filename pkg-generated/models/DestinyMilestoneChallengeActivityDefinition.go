package bungieAPI

type DestinyMilestoneChallengeActivityDefinition struct {

	// The activity for which this challenge is active.
	ActivityHash int                                   `json:"activityHash"`
	Challenges   []DestinyMilestoneChallengeDefinition `json:"challenges"`

	// If the activity and its challenge is visible on any of these nodes, it will be returned.
	ActivityGraphNodes []DestinyMilestoneChallengeActivityGraphNodeEntry `json:"activityGraphNodes"`

	// Phases related to this activity, if there are any.
	// These will be listed in the order in which they will appear in the actual activity.
	Phases []DestinyMilestoneChallengeActivityPhase `json:"phases"`
}
