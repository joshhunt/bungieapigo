package bungieapigo

// Represents the status and other related information for a challenge that is - or was - available
// to a player.
// A challenge is a bonus objective, generally tacked onto Quests or Activities, that provide
// additional variations on play.
type DestinyChallengeStatus struct {

	// The progress - including completion status - of the active challenge.
	Objective DestinyObjectiveProgress `json:"objective"`
}
