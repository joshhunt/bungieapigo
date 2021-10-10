package bungieAPI

// When a Graph needs to show active Progressions, this defines those objectives as well as an
// identifier.
type DestinyActivityGraphDisplayProgressionDefinition struct {
	Id              int `json:"id"`
	ProgressionHash int `json:"progressionHash"`
}
