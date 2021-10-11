package bungieapigo

type DestinyStatsMergeMethod int

const (

	// When collapsing multiple instances of the stat together, add the values.
	DestinyStatsMergeMethodAdd = 0

	// When collapsing multiple instances of the stat together, take the lower value.
	DestinyStatsMergeMethodMin = 1

	// When collapsing multiple instances of the stat together, take the higher value.
	DestinyStatsMergeMethodMax = 2
)
