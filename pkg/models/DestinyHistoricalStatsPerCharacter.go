package bungieapigo

type DestinyHistoricalStatsPerCharacter struct {
	CharacterId int64                                     `json:"characterId,string"`
	Deleted     bool                                      `json:"deleted"`
	Results     map[string]DestinyHistoricalStatsByPeriod `json:"results"`
	Merged      DestinyHistoricalStatsByPeriod            `json:"merged"`
}
