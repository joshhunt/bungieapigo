package bungieAPI

// These definitions represent Factions in the game. Factions have ended up unilaterally being
// related to Vendors that represent them, but that need not necessarily be the case.
// A Faction is really just an entity that has a related progression for which a character can gain
// experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor
// that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to
// this relationship), but Dead Orbit could theoretically exist without the Vendor that
// provides rewards.
type DestinyFactionDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The hash identifier for the DestinyProgressionDefinition that indicates the character's
	// relationship with this faction in terms of experience and levels.
	ProgressionHash int `json:"progressionHash"`

	// The faction token item hashes, and their respective progression values.
	TokenValues map[int]int `json:"tokenValues"`

	// The faction reward item hash, usually an engram.
	RewardItemHash int `json:"rewardItemHash"`

	// The faction reward vendor hash, used for faction engram previews.
	RewardVendorHash int `json:"rewardVendorHash"`

	// List of vendors that are associated with this faction. The last vendor that passes the unlock
	// flag checks is the one that should be shown.
	Vendors []DestinyFactionVendorDefinition `json:"vendors"`

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
