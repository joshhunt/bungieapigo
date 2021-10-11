package bungieapigo

// Represents a single state that a graph node might end up in. Depending on what's going on in the
// game, graph nodes could be shown in different ways or even excluded from view entirely.
type DestinyActivityGraphNodeStateEntry struct {
	State DestinyGraphNodeState `json:"state"`
}
