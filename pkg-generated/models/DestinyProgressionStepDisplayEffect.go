package bungieAPI

// If progression is earned, this determines whether the progression shows visual effects on the
// character or its item - or neither.
type DestinyProgressionStepDisplayEffect int

const (
	DestinyProgressionStepDisplayEffectNone      = 0
	DestinyProgressionStepDisplayEffectCharacter = 1
	DestinyProgressionStepDisplayEffectItem      = 2
)
