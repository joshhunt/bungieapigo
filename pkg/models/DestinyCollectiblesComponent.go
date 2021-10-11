package bungieapigo

type DestinyCollectiblesComponent struct {
	Collectibles map[int]DestinyCollectibleComponent `json:"collectibles"`

	// The hash for the root presentation node definition of Collection categories.
	CollectionCategoriesRootNodeHash int `json:"collectionCategoriesRootNodeHash"`

	// The hash for the root presentation node definition of Collection Badges.
	CollectionBadgesRootNodeHash int `json:"collectionBadgesRootNodeHash"`
}
