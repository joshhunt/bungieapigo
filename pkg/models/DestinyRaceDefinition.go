package bungieapigo

// In Destiny, "Races" are really more like "Species". Sort of. I mean, are the Awoken a separate
// species from humans? I'm not sure. But either way, they're defined here. You'll see Exo,
// Awoken, and Human as examples of these Species. Players will choose one for their character.
type DestinyRaceDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// An enumeration defining the existing, known Races/Species for player characters. This value
	// will be the enum value matching this definition.
	RaceType DestinyRace `json:"raceType"`

	// A localized string referring to the singular form of the Race's name when referred to in
	// gendered form. Keyed by the DestinyGender.
	GenderedRaceNames map[DestinyGender]string `json:"genderedRaceNames"`

	GenderedRaceNamesByGenderHash map[int]string `json:"genderedRaceNamesByGenderHash"`

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
