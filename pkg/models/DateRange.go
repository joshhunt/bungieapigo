package bungieapigo

import "time"

type DateRange struct {
	Start time.Time `json:"start"`
	End   time.Time `json:"end"`
}
