package bungieapigo

// A flags enumeration/bitmask indicating the versions of the game that a given user has
// purchased.
type DestinyGameVersions int

const (
	DestinyGameVersionsNone              = 0
	DestinyGameVersionsDestiny2          = 1
	DestinyGameVersionsDLC1              = 2
	DestinyGameVersionsDLC2              = 4
	DestinyGameVersionsForsaken          = 8
	DestinyGameVersionsYearTwoAnnualPass = 16
	DestinyGameVersionsShadowkeep        = 32
	DestinyGameVersionsBeyondLight       = 64
)
