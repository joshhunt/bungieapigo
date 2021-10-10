package bungieAPI

// Guided Game information for this activity.
type DestinyActivityGuidedBlockDefinition struct {

	// The maximum amount of people that can be in the waiting lobby.
	GuidedMaxLobbySize int `json:"guidedMaxLobbySize"`

	// The minimum amount of people that can be in the waiting lobby.
	GuidedMinLobbySize int `json:"guidedMinLobbySize"`

	// If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.
	GuidedDisbandCount int `json:"guidedDisbandCount"`
}
