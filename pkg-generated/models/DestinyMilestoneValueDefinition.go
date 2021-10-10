package bungieapigo

// The definition for information related to a key/value pair that is relevant for a particular
// Milestone or component within the Milestone. 
// This lets us more flexibly pass up information that's useful to someone, even if it's not
// necessarily us.
type DestinyMilestoneValueDefinition struct {
    Key string `json:"key"`

    // Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
    // tables in the Manifest Database - also have displayable information. This is the base class for
    // that display information.
    DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

}

