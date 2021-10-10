package bungieapigo

// An item can have objectives on it. In practice, these are the exclusive purview of "Quest Step"
// items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.
// Quest steps have 1:M objectives that we end up processing and returning in live data as
// DestinyQuestStatus data, and other useful information.
type DestinyItemObjectiveBlockDefinition struct {

    // The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in
    // the order that they should be rendered.
    ObjectiveHashes []int `json:"objectiveHashes"`


    // For every entry in objectiveHashes, there is a corresponding entry in this array at the same
    // index. If the objective is meant to be associated with a specific DestinyActivityDefinition,
    // there will be a valid hash at that index. Otherwise, it will be invalid (0).
    // Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the
    // same information but may end up with more info in the future.
    DisplayActivityHashes []int `json:"displayActivityHashes"`


    // If True, all objectives must be completed for the step to be completed. If False, any one
    // objective can be completed for the step to be completed.
    RequireFullObjectiveCompletion bool `json:"requireFullObjectiveCompletion"`


    // The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest
    // Step belongs.
    QuestlineItemHash int `json:"questlineItemHash"`


    // The localized string for narrative text related to this quest step, if any.
    Narrative string `json:"narrative"`


    // The localized string describing an action to be performed associated with the objectives, if
    // any.
    ObjectiveVerbName string `json:"objectiveVerbName"`


    // The identifier for the type of quest being performed, if any. Not associated with any fixed
    // definition, yet.
    QuestTypeIdentifier string `json:"questTypeIdentifier"`


    // A hashed value for the questTypeIdentifier, because apparently I like to be redundant.
    QuestTypeHash int `json:"questTypeHash"`


    // One entry per Objective on the item, it will have related display information.
    PerObjectiveDisplayProperties []DestinyObjectiveDisplayProperties `json:"perObjectiveDisplayProperties"`

    DisplayAsStatTracker bool `json:"displayAsStatTracker"`
}

