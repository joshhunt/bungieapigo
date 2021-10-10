package bungieapigo

// Destinations and Activities may have default Activity Graphs that should be shown when you
// bring up the Director and are playing in either.
// This contract defines the graph referred to and the gating for when it is relevant.
type DestinyActivityGraphListEntryDefinition struct {

    // The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening
    // the director.
    ActivityGraphHash int `json:"activityGraphHash"`

}

