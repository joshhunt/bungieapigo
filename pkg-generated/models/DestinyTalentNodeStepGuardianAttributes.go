package bungieAPI

type DestinyTalentNodeStepGuardianAttributes int

const (
	DestinyTalentNodeStepGuardianAttributesNone         = 0
	DestinyTalentNodeStepGuardianAttributesStats        = 1
	DestinyTalentNodeStepGuardianAttributesShields      = 2
	DestinyTalentNodeStepGuardianAttributesHealth       = 4
	DestinyTalentNodeStepGuardianAttributesRevive       = 8
	DestinyTalentNodeStepGuardianAttributesAimUnderFire = 16
	DestinyTalentNodeStepGuardianAttributesRadar        = 32
	DestinyTalentNodeStepGuardianAttributesInvisibility = 64
	DestinyTalentNodeStepGuardianAttributesReputations  = 128
	DestinyTalentNodeStepGuardianAttributesAll          = 255
)
