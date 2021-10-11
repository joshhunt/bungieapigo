package bungieapigo

// Summary information about the activity that was played.
type DestinyHistoricalStatsActivity struct {

	// The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to
	// do over, it'd be named activityHash. Too late now.
	ReferenceId int `json:"referenceId"`

	// The unique hash identifier of the DestinyActivityDefinition that was played.
	DirectorActivityHash int `json:"directorActivityHash"`

	// The unique identifier for this *specific* match that was played.
	// This value can be used to get additional data about this activity such as who else was playing via
	// the GetPostGameCarnageReport endpoint.
	InstanceId int64 `json:"instanceId,string"`

	// Indicates the most specific game mode of the activity that we could find.
	Mode DestinyActivityModeType `json:"mode"`

	// The list of all Activity Modes to which this activity applies, including aggregates. This will
	// let you see, for example, whether the activity was both Clash and part of the Trials of the Nine
	// event.
	Modes []DestinyActivityModeType `json:"modes"`

	// Whether or not the match was a private match.
	IsPrivate bool `json:"isPrivate"`

	// The Membership Type indicating the platform on which this match was played.
	MembershipType BungieMembershipType `json:"membershipType"`
}
