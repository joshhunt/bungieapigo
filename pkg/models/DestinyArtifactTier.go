package bungieapigo

type DestinyArtifactTier struct {
	TierHash       int                       `json:"tierHash"`
	IsUnlocked     bool                      `json:"isUnlocked"`
	PointsToUnlock int                       `json:"pointsToUnlock"`
	Items          []DestinyArtifactTierItem `json:"items"`
}
