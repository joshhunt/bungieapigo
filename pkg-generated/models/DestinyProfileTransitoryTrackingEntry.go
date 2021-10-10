package bungieapigo
import "time"

// This represents a single "thing" being tracked by the player.
// This can point to many types of entities, but only a subset of them will actually have a valid hash
// identifier for whatever it is being pointed to.
// It's up to you to interpret what it means when various combinations of these entries have values
// being tracked.
type DestinyProfileTransitoryTrackingEntry struct {

    // OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that
    // location.
    LocationHash int `json:"locationHash"`


    // OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the
    // identifier for that item.
    ItemHash int `json:"itemHash"`


    // OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the
    // identifier for that objective.
    ObjectiveHash int `json:"objectiveHash"`


    // OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the
    // identifier for that activity.
    ActivityHash int `json:"activityHash"`


    // OPTIONAL - If this is tracking the status of a quest, this is the identifier for the
    // DestinyInventoryItemDefinition that containst that questline data.
    QuestlineItemHash int `json:"questlineItemHash"`


    // OPTIONAL - I've got to level with you, I don't really know what this is. Is it when you started
    // tracking it? Is it only populated for tracked items that have time limits?
    // I don't know, but we can get at it - when I get time to actually test what it is, I'll update this. In
    // the meantime, bask in the mysterious data.
    TrackedDate time.Time `json:"trackedDate"`

}

