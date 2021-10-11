package bungieapigo

type DestinyMetricComponent struct {
	Invisible bool `json:"invisible"`

	// Returns data about a character's status with a given Objective. Combine with
	// DestinyObjectiveDefinition static data for display purposes.
	ObjectiveProgress DestinyObjectiveProgress `json:"objectiveProgress"`
}
