package bungieAPI

type DestinyHistoricalStatsValue struct {

	// Unique ID for this stat
	StatId string `json:"statId"`

	// Basic stat value.
	Basic DestinyHistoricalStatsValuePair `json:"basic"`

	// Per game average for the statistic, if applicable
	Pga DestinyHistoricalStatsValuePair `json:"pga"`

	// Weighted value of the stat if a weight greater than 1 has been assigned.
	Weighted DestinyHistoricalStatsValuePair `json:"weighted"`

	// When a stat represents the best, most, longest, fastest or some other personal best, the actual
	// activity ID where that personal best was established is available on this property.
	ActivityId int64 `json:"activityId"`
}
