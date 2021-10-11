package bungieapigo

type Destiny2CoreSettings struct {
	CollectionRootNode                     int    `json:"collectionRootNode"`
	BadgesRootNode                         int    `json:"badgesRootNode"`
	RecordsRootNode                        int    `json:"recordsRootNode"`
	MedalsRootNode                         int    `json:"medalsRootNode"`
	MetricsRootNode                        int    `json:"metricsRootNode"`
	ActiveTriumphsRootNodeHash             int    `json:"activeTriumphsRootNodeHash"`
	ActiveSealsRootNodeHash                int    `json:"activeSealsRootNodeHash"`
	LegacyTriumphsRootNodeHash             int    `json:"legacyTriumphsRootNodeHash"`
	LegacySealsRootNodeHash                int    `json:"legacySealsRootNodeHash"`
	MedalsRootNodeHash                     int    `json:"medalsRootNodeHash"`
	ExoticCatalystsRootNodeHash            int    `json:"exoticCatalystsRootNodeHash"`
	LoreRootNodeHash                       int    `json:"loreRootNodeHash"`
	CurrentRankProgressionHashes           []int  `json:"currentRankProgressionHashes"`
	UndiscoveredCollectibleImage           string `json:"undiscoveredCollectibleImage"`
	AmmoTypeHeavyIcon                      string `json:"ammoTypeHeavyIcon"`
	AmmoTypeSpecialIcon                    string `json:"ammoTypeSpecialIcon"`
	AmmoTypePrimaryIcon                    string `json:"ammoTypePrimaryIcon"`
	CurrentSeasonalArtifactHash            int    `json:"currentSeasonalArtifactHash"`
	CurrentSeasonHash                      int    `json:"currentSeasonHash"`
	SeasonalChallengesPresentationNodeHash int    `json:"seasonalChallengesPresentationNodeHash"`
	FutureSeasonHashes                     []int  `json:"futureSeasonHashes"`
	PastSeasonHashes                       []int  `json:"pastSeasonHashes"`
}
