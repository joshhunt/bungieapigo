package bungieapigo

// The known entity types that you can have returned from Trending.
type TrendingEntryType int

const (
	TrendingEntryTypeNews            = 0
	TrendingEntryTypeDestinyItem     = 1
	TrendingEntryTypeDestinyActivity = 2
	TrendingEntryTypeDestinyRitual   = 3
	TrendingEntryTypeSupportArticle  = 4
	TrendingEntryTypeCreation        = 5
	TrendingEntryTypeStream          = 6
	TrendingEntryTypeUpdate          = 7
	TrendingEntryTypeLink            = 8
	TrendingEntryTypeForumTag        = 9
	TrendingEntryTypeContainer       = 10
	TrendingEntryTypeRelease         = 11
)
