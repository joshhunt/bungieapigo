package bungieAPI

import "time"

// This component contains base properties of the character. You'll probably want to always
// request this component, but hey you do you.
type DestinyCharacterComponent struct {

	// Every Destiny Profile has a membershipId. This is provided on the character as well for
	// convenience.
	MembershipId int64 `json:"membershipId"`

	// membershipType tells you the platform on which the character plays. Examine the
	// BungieMembershipType enumeration for possible values.
	MembershipType BungieMembershipType `json:"membershipType"`

	// The unique identifier for the character.
	CharacterId int64 `json:"characterId"`

	// The last date that the user played Destiny.
	DateLastPlayed time.Time `json:"dateLastPlayed"`

	// If the user is currently playing, this is how long they've been playing.
	MinutesPlayedThisSession int64 `json:"minutesPlayedThisSession"`

	// If this value is 525,600, then they played Destiny for a year. Or they're a very dedicated Rent
	// fan. Note that this includes idle time, not just time spent actually in activities shooting
	// things.
	MinutesPlayedTotal int64 `json:"minutesPlayedTotal"`

	// The user's calculated "Light Level". Light level is an indicator of your power that mostly
	// matters in the end game, once you've reached the maximum character level: it's a level that's
	// dependent on the average Attack/Defense power of your items.
	Light int `json:"light"`

	// Your character's stats, such as Agility, Resilience, etc... *not* historical stats.
	// You'll have to call a different endpoint for those.
	Stats map[int]int `json:"stats"`

	// Use this hash to look up the character's DestinyRaceDefinition.
	RaceHash int `json:"raceHash"`

	// Use this hash to look up the character's DestinyGenderDefinition.
	GenderHash int `json:"genderHash"`

	// Use this hash to look up the character's DestinyClassDefinition.
	ClassHash int `json:"classHash"`

	// Mostly for historical purposes at this point, this is an enumeration for the character's race.
	// It'll be preferable in the general case to look up the related definition: but for some people
	// this was too convenient to remove.
	RaceType DestinyRace `json:"raceType"`

	// Mostly for historical purposes at this point, this is an enumeration for the character's
	// class.
	// It'll be preferable in the general case to look up the related definition: but for some people
	// this was too convenient to remove.
	ClassType DestinyClass `json:"classType"`

	// Mostly for historical purposes at this point, this is an enumeration for the character's
	// Gender.
	// It'll be preferable in the general case to look up the related definition: but for some people
	// this was too convenient to remove. And yeah, it's an enumeration and not a boolean. Fight me.
	GenderType DestinyGender `json:"genderType"`

	// A shortcut path to the user's currently equipped emblem image. If you're just showing summary
	// info for a user, this is more convenient than examining their equipped emblem and looking up the
	// definition.
	EmblemPath string `json:"emblemPath"`

	// A shortcut path to the user's currently equipped emblem background image. If you're just
	// showing summary info for a user, this is more convenient than examining their equipped emblem
	// and looking up the definition.
	EmblemBackgroundPath string `json:"emblemBackgroundPath"`

	// The hash of the currently equipped emblem for the user. Can be used to look up the
	// DestinyInventoryItemDefinition.
	EmblemHash int `json:"emblemHash"`

	// A shortcut for getting the background color of the user's currently equipped emblem without
	// having to do a DestinyInventoryItemDefinition lookup.
	EmblemColor DestinyColor `json:"emblemColor"`

	// The progression that indicates your character's level. Not their light level, but their
	// character level: you know, the thing you max out a couple hours in and then ignore for the sake of
	// light level.
	LevelProgression DestinyProgression `json:"levelProgression"`

	// The "base" level of your character, not accounting for any light level.
	BaseCharacterLevel int `json:"baseCharacterLevel"`

	// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next
	// character level.
	PercentToNextLevel float64 `json:"percentToNextLevel"`

	// If this Character has a title assigned to it, this is the identifier of the
	// DestinyRecordDefinition that has that title information.
	TitleRecordHash int `json:"titleRecordHash"`
}
