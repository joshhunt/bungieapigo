package bungieAPI

// Represents the different states a progression reward item can be in.
type DestinyProgressionRewardItemState int

const (
	DestinyProgressionRewardItemStateNone = 0

	// If this is set, the reward should be hidden.
	DestinyProgressionRewardItemStateInvisible = 1

	// If this is set, the reward has been earned.
	DestinyProgressionRewardItemStateEarned = 2

	// If this is set, the reward has been claimed.
	DestinyProgressionRewardItemStateClaimed = 4

	// If this is set, the reward is allowed to be claimed by this Character. An item can be earned but still can't be claimed in certain circumstances, like if it's only allowed for certain subclasses. It also might not be able to be claimed if you already claimed it!
	DestinyProgressionRewardItemStateClaimAllowed = 8
)
