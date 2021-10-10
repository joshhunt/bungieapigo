package bungieapigo

type DestinyHistoricalStatsByPeriod struct {
    AllTime map[string]DestinyHistoricalStatsValue `json:"allTime"`
    AllTimeTier1 map[string]DestinyHistoricalStatsValue `json:"allTimeTier1"`
    AllTimeTier2 map[string]DestinyHistoricalStatsValue `json:"allTimeTier2"`
    AllTimeTier3 map[string]DestinyHistoricalStatsValue `json:"allTimeTier3"`
    Daily []DestinyHistoricalStatsPeriodGroup `json:"daily"`
    Monthly []DestinyHistoricalStatsPeriodGroup `json:"monthly"`
}

