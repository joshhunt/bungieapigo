package bungieAPI

type DestinyLeaderboardResults struct {

	// Indicate the membership ID of the account that is the focal point of the provided leaderboards.
	FocusMembershipId int64 `json:"focusMembershipId"`

	// Indicate the character ID of the character that is the focal point of the provided
	// leaderboards. May be null, in which case any character from the focus membership can appear in
	// the provided leaderboards.
	FocusCharacterId int64 `json:"focusCharacterId"`
}
