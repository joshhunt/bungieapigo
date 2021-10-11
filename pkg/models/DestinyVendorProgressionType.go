package bungieapigo

// Describes the type of progression that a vendor has.
type DestinyVendorProgressionType int

const (

	// The original rank progression from token redemption.
	DestinyVendorProgressionTypeDefault = 0

	// Progression from ranks in ritual content. For example: Crucible (Shaxx), Gambit (Drifter),
	// and Season 13 Battlegrounds (War Table).
	DestinyVendorProgressionTypeRitual = 1
)
