package bungieapigo

type DestinyProfileCollectiblesComponent struct {

    // The list of collectibles determined by the game as having been "recently" acquired.
    RecentCollectibleHashes []int `json:"recentCollectibleHashes"`


    // The list of collectibles determined by the game as having been "recently" acquired.
    // The game client itself actually controls this data, so I personally question whether anyone
    // will get much use out of this: because we can't edit this value through the API. But in case anyone
    // finds it useful, here it is.
    NewnessFlaggedCollectibleHashes []int `json:"newnessFlaggedCollectibleHashes"`

    Collectibles map[int]DestinyCollectibleComponent `json:"collectibles"`

    // The hash for the root presentation node definition of Collection categories.
    CollectionCategoriesRootNodeHash int `json:"collectionCategoriesRootNodeHash"`


    // The hash for the root presentation node definition of Collection Badges.
    CollectionBadgesRootNodeHash int `json:"collectionBadgesRootNodeHash"`

}

