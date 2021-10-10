package bungieapigo
import "time"

// Items can have objectives and progression. When you request this block, you will obtain
// information about any Objectives and progression tied to this item.
type DestinyItemObjectivesComponent struct {

    // If the item has a hard association with objectives, your progress on them will be defined here. 
    // Objectives are our standard way to describe a series of tasks that have to be completed for a
    // reward.
    Objectives []DestinyObjectiveProgress `json:"objectives"`


    // I may regret naming it this way - but this represents when an item has an objective that doesn't
    // serve a beneficial purpose, but rather is used for "flavor" or additional information. For
    // instance, when Emblems track specific stats, those stats are represented as Objectives on the
    // item.
    FlavorObjective DestinyObjectiveProgress `json:"flavorObjective"`


    // If we have any information on when these objectives were completed, this will be the date of that
    // completion. This won't be on many items, but could be interesting for some items that do store
    // this information.
    DateCompleted time.Time `json:"dateCompleted"`

}

