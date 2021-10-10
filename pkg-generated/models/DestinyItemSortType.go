package bungieAPI

// Determines how items are sorted in an inventory bucket.
type DestinyItemSortType int

const (
	DestinyItemSortTypeItemId    = 0
	DestinyItemSortTypeTimestamp = 1
	DestinyItemSortTypeStackSize = 2
)
