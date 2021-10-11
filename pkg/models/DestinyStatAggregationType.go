package bungieapigo

// When a Stat (DestinyStatDefinition) is aggregated, this is the rules used for determining the
// level and formula used for aggregation.
// * CharacterAverage = apply a weighted average using the related DestinyStatGroupDefinition
// on the DestinyInventoryItemDefinition across the character's equipped items. See both of
// those definitions for details. * Character = don't aggregate: the stat should be located and
// used directly on the character. * Item = don't aggregate: the stat should be located and used
// directly on the item.
type DestinyStatAggregationType int

const (
	DestinyStatAggregationTypeCharacterAverage = 0
	DestinyStatAggregationTypeCharacter        = 1
	DestinyStatAggregationTypeItem             = 2
)
