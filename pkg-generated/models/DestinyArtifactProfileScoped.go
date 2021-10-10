package bungieAPI

// Represents a Seasonal Artifact and all data related to it for the requested Account.
// It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
type DestinyArtifactProfileScoped struct {
	ArtifactHash int `json:"artifactHash"`

	// Information about a current character's status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.
	PointProgression DestinyProgression `json:"pointProgression"`
	PointsAcquired   int                `json:"pointsAcquired"`

	// Information about a current character's status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.
	PowerBonusProgression DestinyProgression `json:"powerBonusProgression"`
	PowerBonus            int                `json:"powerBonus"`
}
