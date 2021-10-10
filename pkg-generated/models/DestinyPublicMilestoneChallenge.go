package bungieAPI

// A Milestone can have many Challenges. Challenges are just extra Objectives that provide a fun way to mix-up play and provide extra rewards.
type DestinyPublicMilestoneChallenge struct {

	// The objective for the Challenge, which should have human-readable data about what needs to be done to accomplish the objective. Use this hash to look up the DestinyObjectiveDefinition.
	ObjectiveHash int `json:"objectiveHash"`

	// IF the Objective is related to a specific Activity, this will be that activity's hash. Use it to look up the DestinyActivityDefinition for additional data to show.
	ActivityHash int `json:"activityHash"`
}
