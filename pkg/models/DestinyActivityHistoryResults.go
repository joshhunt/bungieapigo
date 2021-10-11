package bungieapigo

type DestinyActivityHistoryResults struct {

	// List of activities, the most recent activity first.
	Activities []DestinyHistoricalStatsPeriodGroup `json:"activities"`
}
