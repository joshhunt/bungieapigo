package bungieAPI

// As/if presentation nodes begin to host more entities as children, these lists will be added to. One list property exists per type of entity that can be treated as a child of this presentation node, and each holds the identifier of the entity and any associated information needed to display the UI for that entity (if anything)
type DestinyPresentationNodeChildrenBlock struct {
	PresentationNodes []DestinyPresentationNodeChildEntry            `json:"presentationNodes"`
	Collectibles      []DestinyPresentationNodeCollectibleChildEntry `json:"collectibles"`
	Records           []DestinyPresentationNodeRecordChildEntry      `json:"records"`
	Metrics           []DestinyPresentationNodeMetricChildEntry      `json:"metrics"`
}
