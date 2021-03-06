package bungieapigo

import "time"

// This component holds activity data for a character. It will tell you about the character's
// current activity status, as well as activities that are available to the user.
type DestinyCharacterActivitiesComponent struct {

	// The last date that the user started playing an activity.
	DateActivityStarted time.Time `json:"dateActivityStarted"`

	// The list of activities that the user can play.
	AvailableActivities []DestinyActivity `json:"availableActivities"`

	// If the user is in an activity, this will be the hash of the Activity being played. Note that you
	// must combine this info with currentActivityModeHash to get a real picture of what the user is
	// doing right now. For instance, PVP "Activities" are just maps: it's the ActivityMode that
	// determines what type of PVP game they're playing.
	CurrentActivityHash int `json:"currentActivityHash"`

	// If the user is in an activity, this will be the hash of the activity mode being played. Combine
	// with currentActivityHash to give a person a full picture of what they're doing right now.
	CurrentActivityModeHash int `json:"currentActivityModeHash"`

	// And the current activity's most specific mode type, if it can be found.
	CurrentActivityModeType int `json:"currentActivityModeType"`

	// If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition
	// being played. Combine with currentActivityHash to give a person a full picture of what they're
	// doing right now.
	CurrentActivityModeHashes []int `json:"currentActivityModeHashes"`

	// All Activity Modes that apply to the current activity being played, in enum form.
	CurrentActivityModeTypes []DestinyActivityModeType `json:"currentActivityModeTypes"`

	// If the user is in a playlist, this is the hash identifier for the playlist that they chose.
	CurrentPlaylistActivityHash int `json:"currentPlaylistActivityHash"`

	// This will have the activity hash of the last completed story/campaign mission, in case you care
	// about that.
	LastCompletedStoryHash int `json:"lastCompletedStoryHash"`
}
