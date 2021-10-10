package bungieAPI

type DestinyAggregateActivityStats struct {

	// Hash ID that can be looked up in the DestinyActivityTable.
	ActivityHash int `json:"activityHash"`

	// Collection of stats for the player in this activity.
	Values map[string]DestinyHistoricalStatsValue `json:"values"`
}
