package bungieAPI

// Represents the possible and known UI styles used by the game for rendering Socket Categories.
type DestinySocketCategoryStyle int

const (
	DestinySocketCategoryStyleUnknown     = 0
	DestinySocketCategoryStyleReusable    = 1
	DestinySocketCategoryStyleConsumable  = 2
	DestinySocketCategoryStyleUnlockable  = 3
	DestinySocketCategoryStyleIntrinsic   = 4
	DestinySocketCategoryStyleEnergyMeter = 5
	DestinySocketCategoryStyleLargePerk   = 6
	DestinySocketCategoryStyleAbilities   = 7
	DestinySocketCategoryStyleSupers      = 8
)
