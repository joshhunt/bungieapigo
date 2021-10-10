package bungieAPI

// The metrics available for display and selection on an item.
type DestinyItemMetricBlockDefinition struct {

	// Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list
	// available metrics. Any metric listed directly below these nodes, or in any of these nodes'
	// children will be made available for selection.
	AvailableMetricCategoryNodeHashes []int `json:"availableMetricCategoryNodeHashes"`
}
