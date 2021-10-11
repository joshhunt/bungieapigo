package bungieapigo

// Represents a stat on an item *or* Character (NOT a Historical Stat, but a physical attribute
// stat like Attack, Defense etc...)
type DestinyStat struct {

	// The hash identifier for the Stat. Use it to look up the DestinyStatDefinition for static data
	// about the stat.
	StatHash int `json:"statHash"`

	// The current value of the Stat.
	Value int `json:"value"`
}
