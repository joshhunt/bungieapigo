package bungieAPI

// Defines a Character Class in Destiny 2. These are types of characters you can play, like Titan, Warlock, and Hunter.
type DestinyClassDefinition struct {

	// In Destiny 1, we added a convenience Enumeration for referring to classes. We've kept it, though mostly for posterity. This is the enum value for this definition's class.
	ClassType DestinyClass `json:"classType"`

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// A localized string referring to the singular form of the Class's name when referred to in gendered form. Keyed by the DestinyGender.
	GenderedClassNames             map[DestinyGender]string `json:"genderedClassNames"`
	GenderedClassNamesByGenderHash map[int]string           `json:"genderedClassNamesByGenderHash"`

	// Mentors don't really mean anything anymore. Don't expect this to be populated.
	MentorVendorHash int `json:"mentorVendorHash"`

	// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
	// When entities refer to each other in Destiny content, it is this hash that they are referring to.
	Hash int `json:"hash"`

	// The index of the entity as it was found in the investment tables.
	Index int `json:"index"`

	// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
	Redacted bool `json:"redacted"`
}
