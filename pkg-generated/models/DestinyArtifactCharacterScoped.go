package bungieapigo

type DestinyArtifactCharacterScoped struct {
    ArtifactHash int `json:"artifactHash"`
    PointsUsed int `json:"pointsUsed"`
    ResetCount int `json:"resetCount"`
    Tiers []DestinyArtifactTier `json:"tiers"`
}

