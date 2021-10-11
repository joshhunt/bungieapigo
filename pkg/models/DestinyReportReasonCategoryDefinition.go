package bungieapigo

// If you're going to report someone for a Terms of Service violation, you need to choose a category
// and reason for the report. This definition holds both the categories and the reasons within
// those categories, for simplicity and my own laziness' sake.
// Note tha this means that, to refer to a Reason by reasonHash, you need a combination of the
// reasonHash *and* the associated ReasonCategory's hash: there are some reasons defined under
// multiple categories.
type DestinyReportReasonCategoryDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The specific reasons for the report under this category.
	Reasons map[int]DestinyReportReasonDefinition `json:"reasons"`

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
