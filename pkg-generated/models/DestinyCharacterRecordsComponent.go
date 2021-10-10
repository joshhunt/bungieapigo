package bungieAPI

type DestinyCharacterRecordsComponent struct {
	FeaturedRecordHashes []int                          `json:"featuredRecordHashes"`
	Records              map[int]DestinyRecordComponent `json:"records"`

	// The hash for the root presentation node definition of Triumph categories.
	RecordCategoriesRootNodeHash int `json:"recordCategoriesRootNodeHash"`

	// The hash for the root presentation node definition of Triumph Seals.
	RecordSealsRootNodeHash int `json:"recordSealsRootNodeHash"`
}
