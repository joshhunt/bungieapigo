package bungieAPI

// A Flags enumeration representing the reasons why a person can't join this user's fireteam.
type DestinyJoinClosedReasons int

const (
	DestinyJoinClosedReasonsNone = 0

	// The user is currently in matchmaking.
	DestinyJoinClosedReasonsInMatchmaking = 1

	// The user is currently in a loading screen.
	DestinyJoinClosedReasonsLoading = 2

	// The user is in an activity that requires solo play.
	DestinyJoinClosedReasonsSoloMode = 4

	// The user can't be joined for one of a variety of internal reasons. Basically, the game can't let
	// you join at this time, but for reasons that aren't under the control of this user.
	DestinyJoinClosedReasonsInternalReasons = 8

	// The user's current activity/quest/other transitory game state is preventing joining.
	DestinyJoinClosedReasonsDisallowedByGameState = 16

	// The user appears to be offline.
	DestinyJoinClosedReasonsOffline = 32768
)
