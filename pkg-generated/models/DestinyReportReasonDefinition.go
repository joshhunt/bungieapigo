package bungieapigo

// A specific reason for being banned. Only accessible under the related category
// (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that
// report reasons' reasonHash are not globally unique: and indeed, entries like "Other" are
// defined under most categories for example.
type DestinyReportReasonDefinition struct {

    // The identifier for the reason: they are only guaranteed unique under the Category in which they
    // are found.
    ReasonHash int `json:"reasonHash"`


    // Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
    // tables in the Manifest Database - also have displayable information. This is the base class for
    // that display information.
    DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

}

