package bungieAPI

// Represents this player's personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won't, or the concept won't apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn't make sense to talk about a Crucible Playlist in those terms.
type DestinyMilestoneActivityCompletionStatus struct {

	// If the activity has been "completed", that information will be returned here.
	Completed bool `json:"completed"`

	// If the Activity has discrete "phases" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
	Phases []DestinyMilestoneActivityPhase `json:"phases"`
}
