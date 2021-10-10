package bungieAPI

// Defines a 'power cap' (limit) for gear items, based on the rarity tier and season of release.
type DestinyPowerCapDefinition struct {

	// The raw value for a power cap.
	PowerCap int `json:"powerCap"`

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
