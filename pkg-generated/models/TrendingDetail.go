package bungieAPI

type TrendingDetail struct {
	Identifier      string                         `json:"identifier"`
	EntityType      TrendingEntryType              `json:"entityType"`
	News            TrendingEntryNews              `json:"news"`
	Support         TrendingEntrySupportArticle    `json:"support"`
	DestinyItem     TrendingEntryDestinyItem       `json:"destinyItem"`
	DestinyActivity TrendingEntryDestinyActivity   `json:"destinyActivity"`
	DestinyRitual   TrendingEntryDestinyRitual     `json:"destinyRitual"`
	Creation        TrendingEntryCommunityCreation `json:"creation"`
}
