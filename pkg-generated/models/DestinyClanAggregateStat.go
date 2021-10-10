package bungieAPI

type DestinyClanAggregateStat struct {

	// The id of the mode of stats (allPvp, allPvE, etc)
	Mode DestinyActivityModeType `json:"mode"`

	// The id of the stat
	StatId string `json:"statId"`

	// Value of the stat for this player
	Value DestinyHistoricalStatsValue `json:"value"`
}
