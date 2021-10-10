package bungieAPI

// These properties are an attempt to categorize talent node steps by certain common properties.
// See the related enumerations for the type of properties being categorized.
type DestinyTalentNodeStepGroups struct {
	WeaponPerformance  DestinyTalentNodeStepWeaponPerformances `json:"weaponPerformance"`
	ImpactEffects      DestinyTalentNodeStepImpactEffects      `json:"impactEffects"`
	GuardianAttributes DestinyTalentNodeStepGuardianAttributes `json:"guardianAttributes"`
	LightAbilities     DestinyTalentNodeStepLightAbilities     `json:"lightAbilities"`
	DamageTypes        DestinyTalentNodeStepDamageTypes        `json:"damageTypes"`
}
