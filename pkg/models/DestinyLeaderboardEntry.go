package bungieapigo

type DestinyLeaderboardEntry struct {

	// Where this player ranks on the leaderboard. A value of 1 is the top rank.
	Rank int `json:"rank"`

	// Identity details of the player
	Player DestinyPlayer `json:"player"`

	// ID of the player's best character for the reported stat.
	CharacterId int64 `json:"characterId,string"`

	// Value of the stat for this player
	Value DestinyHistoricalStatsValue `json:"value"`
}
