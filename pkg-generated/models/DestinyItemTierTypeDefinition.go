package bungieAPI

// Defines the tier type of an item. Mostly this provides human readable properties for types like
// Common, Rare, etc...
// It also provides some base data for infusion that could be useful.
type DestinyItemTierTypeDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// If this tier defines infusion properties, they will be contained here.
	InfusionProcess DestinyItemTierTypeInfusionBlock `json:"infusionProcess"`

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
