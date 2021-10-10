package bungieAPI

import "time"

type Datapoint struct {

	// Timestamp for the related count.
	Time time.Time `json:"time"`

	// Count associated with timestamp
	Count float64 `json:"count"`
}
