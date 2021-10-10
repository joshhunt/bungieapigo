package bungieAPI

type DestinyPostGameCarnageReportEntry struct {

	// Standing of the player
	Standing int `json:"standing"`

	// Score of the player if available
	Score DestinyHistoricalStatsValue `json:"score"`

	// Identity details of the player
	Player DestinyPlayer `json:"player"`

	// ID of the player's character used in the activity.
	CharacterId int64 `json:"characterId"`

	// Collection of stats for the player in this activity.
	Values map[string]DestinyHistoricalStatsValue `json:"values"`

	// Extended data extracted from the activity blob.
	Extended DestinyPostGameCarnageReportExtendedData `json:"extended"`
}
