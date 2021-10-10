package bungieAPI

// An enumeration representing the potential difficulty levels of an activity. Their names
// are... more qualitative than quantitative.
type DestinyActivityDifficultyTier int

const (
	DestinyActivityDifficultyTierTrivial          = 0
	DestinyActivityDifficultyTierEasy             = 1
	DestinyActivityDifficultyTierNormal           = 2
	DestinyActivityDifficultyTierChallenging      = 3
	DestinyActivityDifficultyTierHard             = 4
	DestinyActivityDifficultyTierBrave            = 5
	DestinyActivityDifficultyTierAlmostImpossible = 6
	DestinyActivityDifficultyTierImpossible       = 7
)
