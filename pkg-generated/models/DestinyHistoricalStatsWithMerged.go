package bungieapigo

type DestinyHistoricalStatsWithMerged struct {
    Results map[string]DestinyHistoricalStatsByPeriod `json:"results"`
    Merged DestinyHistoricalStatsByPeriod `json:"merged"`
}

