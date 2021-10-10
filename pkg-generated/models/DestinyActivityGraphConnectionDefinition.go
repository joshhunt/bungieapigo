package bungieAPI

// Nodes on a graph can be visually connected: this appears to be the information about which nodes to link. It appears to lack more detailed information, such as the path for that linking.
type DestinyActivityGraphConnectionDefinition struct {
	SourceNodeHash int `json:"sourceNodeHash"`
	DestNodeHash   int `json:"destNodeHash"`
}
