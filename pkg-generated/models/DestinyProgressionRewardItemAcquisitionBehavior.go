package bungieapigo

// Represents the different kinds of acquisition behavior for progression reward items.
type DestinyProgressionRewardItemAcquisitionBehavior int

const (
    DestinyProgressionRewardItemAcquisitionBehaviorInstant = 0
    DestinyProgressionRewardItemAcquisitionBehaviorPlayerClaimRequired = 1
)