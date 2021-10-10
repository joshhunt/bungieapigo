package bungieapigo

type DestinyRecordsComponent struct {
    Records map[int]DestinyRecordComponent `json:"records"`

    // The hash for the root presentation node definition of Triumph categories.
    RecordCategoriesRootNodeHash int `json:"recordCategoriesRootNodeHash"`


    // The hash for the root presentation node definition of Triumph Seals.
    RecordSealsRootNodeHash int `json:"recordSealsRootNodeHash"`

}

