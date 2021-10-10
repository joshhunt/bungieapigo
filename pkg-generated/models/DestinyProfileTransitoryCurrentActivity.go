package bungieAPI

import "time"

// If you are playing in an activity, this is some information about it.
// Note that we cannot guarantee any of this resembles what ends up in the PGCR in any way. They are
// sourced by two entirely separate systems with their own logic, and the one we source this data
// from should be considered non-authoritative in comparison.
type DestinyProfileTransitoryCurrentActivity struct {

	// When the activity started.
	StartTime time.Time `json:"startTime"`

	// If you're still in it but it "ended" (like when folks are dancing around the loot after they beat a
	// boss), this is when the activity ended.
	EndTime time.Time `json:"endTime"`

	// This is what our non-authoritative source thought the score was.
	Score float64 `json:"score"`

	// If you have human opponents, this is the highest opposing team's score.
	HighestOpposingFactionScore float64 `json:"highestOpposingFactionScore"`

	// This is how many human or poorly crafted aimbot opponents you have.
	NumberOfOpponents int `json:"numberOfOpponents"`

	// This is how many human or poorly crafted aimbots are on your team.
	NumberOfPlayers int `json:"numberOfPlayers"`
}
