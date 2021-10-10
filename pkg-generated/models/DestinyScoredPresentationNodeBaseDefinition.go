package bungieAPI

type DestinyScoredPresentationNodeBaseDefinition struct {
	MaxCategoryRecordScore int                         `json:"maxCategoryRecordScore"`
	PresentationNodeType   DestinyPresentationNodeType `json:"presentationNodeType"`
	TraitIds               []string                    `json:"traitIds"`
	TraitHashes            []int                       `json:"traitHashes"`

	// A quick reference to presentation nodes that have this node as a child. Presentation nodes can
	// be parented under multiple parents.
	ParentNodeHashes []int `json:"parentNodeHashes"`

	// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not
	// globally.
	// When entities refer to each other in Destiny content, it is this hash that they are referring to.
	Hash int `json:"hash"`

	// The index of the entity as it was found in the investment tables.
	Index int `json:"index"`

	// If this is true, then there is an entity with this identifier/type combination, but BNet is not
	// yet allowed to show it. Sorry!
	Redacted bool `json:"redacted"`
}
