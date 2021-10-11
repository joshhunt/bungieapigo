package bungieapigo

type DestinyRecordDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// Indicates whether this Record's state is determined on a per-character or on an account-wide
	// basis.
	Scope DestinyScope `json:"scope"`

	PresentationInfo DestinyPresentationChildBlock `json:"presentationInfo"`
	LoreHash         int                           `json:"loreHash"`
	ObjectiveHashes  []int                         `json:"objectiveHashes"`
	RecordValueStyle DestinyRecordValueStyle       `json:"recordValueStyle"`
	ForTitleGilding  bool                          `json:"forTitleGilding"`
	TitleInfo        DestinyRecordTitleBlock       `json:"titleInfo"`
	CompletionInfo   DestinyRecordCompletionBlock  `json:"completionInfo"`
	StateInfo        SchemaRecordStateBlock        `json:"stateInfo"`

	// Presentation nodes can be restricted by various requirements. This defines the rules of those
	// requirements, and the message(s) to be shown if these requirements aren't met.
	Requirements DestinyPresentationNodeRequirementsBlock `json:"requirements"`

	// If this record has an expiration after which it cannot be earned, this is some information about
	// that expiration.
	ExpirationInfo DestinyRecordExpirationBlock `json:"expirationInfo"`

	// Some records have multiple 'interval' objectives, and the record may be claimed at each
	// completed interval
	IntervalInfo DestinyRecordIntervalBlock `json:"intervalInfo"`

	// If there is any publicly available information about rewards earned for achieving this
	// record, this is the list of those items.
	//  However, note that some records intentionally have "hidden" rewards. These will not be
	// returned in this list.
	RewardItems []DestinyItemQuantity `json:"rewardItems"`

	PresentationNodeType DestinyPresentationNodeType `json:"presentationNodeType"`
	TraitIds             []string                    `json:"traitIds"`
	TraitHashes          []int                       `json:"traitHashes"`

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
