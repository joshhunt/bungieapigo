package bungieAPI

// Some Objectives provide perks, generally as part of providing some kind of interesting modifier for a Challenge or Quest. This indicates when the Perk is granted.
type DestinyObjectiveGrantStyle int

const (
	DestinyObjectiveGrantStyleWhenIncomplete = 0
	DestinyObjectiveGrantStyleWhenComplete   = 1
	DestinyObjectiveGrantStyleAlways         = 2
)
