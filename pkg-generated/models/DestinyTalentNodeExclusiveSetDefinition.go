package bungieAPI

// The list of indexes into the Talent Grid's "nodes" property for nodes in this exclusive set.
// (See DestinyTalentNodeDefinition.nodeIndex)
type DestinyTalentNodeExclusiveSetDefinition struct {

	// The list of node indexes for the exclusive set. Historically, these were indexes. I would have
	// liked to replace this with nodeHashes for consistency, but it's way too late for that. (9:09 PM,
	// he's right!)
	NodeIndexes []int `json:"nodeIndexes"`
}
