package bungieapigo

type DestinyTalentNodeState int

const (
    DestinyTalentNodeStateInvalid = 0
    DestinyTalentNodeStateCanUpgrade = 1
    DestinyTalentNodeStateNoPoints = 2
    DestinyTalentNodeStateNoPrerequisites = 3
    DestinyTalentNodeStateNoSteps = 4
    DestinyTalentNodeStateNoUnlock = 5
    DestinyTalentNodeStateNoMaterial = 6
    DestinyTalentNodeStateNoGridLevel = 7
    DestinyTalentNodeStateSwappingLocked = 8
    DestinyTalentNodeStateMustSwap = 9
    DestinyTalentNodeStateComplete = 10
    DestinyTalentNodeStateUnknown = 11
    DestinyTalentNodeStateCreationOnly = 12
    DestinyTalentNodeStateHidden = 13
)