package bungieapigo

// If the activity is a playlist, this is the definition for a specific entry in the playlist: a
// single possible combination of Activity and Activity Mode that can be chosen.
type DestinyActivityPlaylistItemDefinition struct {

	// The hash identifier of the Activity that can be played. Use it to look up the
	// DestinyActivityDefinition.
	ActivityHash int `json:"activityHash"`

	// If this playlist entry had an activity mode directly defined on it, this will be the hash of that
	// mode.
	DirectActivityModeHash int `json:"directActivityModeHash"`

	// If the playlist entry had an activity mode directly defined on it, this will be the enum value of
	// that mode.
	DirectActivityModeType int `json:"directActivityModeType"`

	// The hash identifiers for Activity Modes relevant to this entry.
	ActivityModeHashes []int `json:"activityModeHashes"`

	// The activity modes - if any - in enum form. Because we can't seem to escape the enums.
	ActivityModeTypes []DestinyActivityModeType `json:"activityModeTypes"`
}
