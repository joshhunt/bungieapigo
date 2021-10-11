package bungieapigo

// A PresentationNode is an entity that represents a logical grouping of other entities
// visually/organizationally.
// For now, Presentation Nodes may contain the following... but it may be used for more in the
// future:
// - Collectibles - Records (Or, as the public will call them, "Triumphs." Don't ask me why we're
// overloading the term "Triumph", it still hurts me to think about it) - Metrics (aka Stat
// Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created
// Part of me wants to break these into conceptual definitions per entity being collected, but the
// possibility of these different types being mixed in the same UI and the possibility that it
// could actually be more useful to return the "bare metal" presentation node concept has
// resulted in me deciding against that for the time being.
// We'll see if I come to regret this as well.
type DestinyPresentationNodeDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The original icon for this presentation node, before we futzed with it.
	OriginalIcon string `json:"originalIcon"`

	// Some presentation nodes are meant to be explicitly shown on the "root" or "entry" screens for
	// the feature to which they are related. You should use this icon when showing them on such a view,
	// if you have a similar "entry point" view in your UI. If you don't have a UI, then I guess it doesn't
	// matter either way does it?
	RootViewIcon string `json:"rootViewIcon"`

	NodeType DestinyPresentationNodeType `json:"nodeType"`

	// Indicates whether this presentation node's state is determined on a per-character or on an
	// account-wide basis.
	Scope DestinyScope `json:"scope"`

	// If this presentation node shows a related objective (for instance, if it tracks the progress of
	// its children), the objective being tracked is indicated here.
	ObjectiveHash int `json:"objectiveHash"`

	// If this presentation node has an associated "Record" that you can accomplish for completing
	// its children, this is the identifier of that Record.
	CompletionRecordHash int `json:"completionRecordHash"`

	// The child entities contained by this presentation node.
	Children DestinyPresentationNodeChildrenBlock `json:"children"`

	// A hint for how to display this presentation node when it's shown in a list.
	DisplayStyle DestinyPresentationDisplayStyle `json:"displayStyle"`

	// A hint for how to display this presentation node when it's shown in its own detail screen.
	ScreenStyle DestinyPresentationScreenStyle `json:"screenStyle"`

	// The requirements for being able to interact with this presentation node and its children.
	Requirements DestinyPresentationNodeRequirementsBlock `json:"requirements"`

	// If this presentation node has children, but the game doesn't let you inspect the details of
	// those children, that is indicated here.
	DisableChildSubscreenNavigation bool `json:"disableChildSubscreenNavigation"`

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
