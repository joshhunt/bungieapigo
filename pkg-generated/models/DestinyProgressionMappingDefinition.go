package bungieAPI

// Aggregations of multiple progressions.
// These are used to apply rewards to multiple progressions at once. They can sometimes have human
// readable data as well, but only extremely sporadically.
type DestinyProgressionMappingDefinition struct {

	// Infrequently defined in practice. Defer to the individual progressions' display
	// properties.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The localized unit of measurement for progression across the progressions defined in this
	// mapping. Unfortunately, this is very infrequently defined. Defer to the individual
	// progressions' display units.
	DisplayUnits string `json:"displayUnits"`

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
