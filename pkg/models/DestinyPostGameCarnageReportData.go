package bungieapigo

import "time"

type DestinyPostGameCarnageReportData struct {

	// Date and time for the activity.
	Period time.Time `json:"period"`

	// If this activity has "phases", this is the phase at which the activity was started.
	StartingPhaseIndex int `json:"startingPhaseIndex"`

	// Details about the activity.
	ActivityDetails DestinyHistoricalStatsActivity `json:"activityDetails"`

	// Collection of players and their data for this activity.
	Entries []DestinyPostGameCarnageReportEntry `json:"entries"`

	// Collection of stats for the player in this activity.
	Teams []DestinyPostGameCarnageReportTeamEntry `json:"teams"`
}
