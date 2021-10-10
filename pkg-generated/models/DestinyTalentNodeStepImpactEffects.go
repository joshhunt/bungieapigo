package bungieAPI

type DestinyTalentNodeStepImpactEffects int

const (
	DestinyTalentNodeStepImpactEffectsNone             = 0
	DestinyTalentNodeStepImpactEffectsArmorPiercing    = 1
	DestinyTalentNodeStepImpactEffectsRicochet         = 2
	DestinyTalentNodeStepImpactEffectsFlinch           = 4
	DestinyTalentNodeStepImpactEffectsCollateralDamage = 8
	DestinyTalentNodeStepImpactEffectsDisorient        = 16
	DestinyTalentNodeStepImpactEffectsHighlightTarget  = 32
	DestinyTalentNodeStepImpactEffectsAll              = 63
)
