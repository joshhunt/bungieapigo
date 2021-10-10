package bungieAPI

// All damage types that are possible in the game are defined here, along with localized info and
// icons as needed.
type DestinyDamageTypeDefinition struct {

	// The description of the damage type, icon etc...
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// A variant of the icon that is transparent and colorless.
	TransparentIconPath string `json:"transparentIconPath"`

	// If TRUE, the game shows this damage type's icon. Otherwise, it doesn't. Whether you show it or
	// not is up to you.
	ShowIcon bool `json:"showIcon"`

	// We have an enumeration for damage types for quick reference. This is the current definition's
	// damage type enum value.
	EnumValue DamageType `json:"enumValue"`

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
