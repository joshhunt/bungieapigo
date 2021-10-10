package bungieAPI

type DestinyHistoricalStatsAccountResult struct {
	MergedDeletedCharacters DestinyHistoricalStatsWithMerged     `json:"mergedDeletedCharacters"`
	MergedAllCharacters     DestinyHistoricalStatsWithMerged     `json:"mergedAllCharacters"`
	Characters              []DestinyHistoricalStatsPerCharacter `json:"characters"`
}
