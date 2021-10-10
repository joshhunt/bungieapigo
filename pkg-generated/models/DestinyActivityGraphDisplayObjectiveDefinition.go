package bungieAPI

// When a Graph needs to show active Objectives, this defines those objectives as well as an
// identifier.
type DestinyActivityGraphDisplayObjectiveDefinition struct {

	// $NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up
	// objectives to display info. I am unsure how it works.
	Id int `json:"id"`

	// The objective being shown on the map.
	ObjectiveHash int `json:"objectiveHash"`
}
