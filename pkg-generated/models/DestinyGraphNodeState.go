package bungieAPI

// Represents a potential state of an Activity Graph node.
type DestinyGraphNodeState int

const (
	DestinyGraphNodeStateHidden     = 0
	DestinyGraphNodeStateVisible    = 1
	DestinyGraphNodeStateTeaser     = 2
	DestinyGraphNodeStateIncomplete = 3
	DestinyGraphNodeStateCompleted  = 4
)
