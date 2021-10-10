package bungieapigo

// This defines a single Step in a progression (which roughly equates to a level. See
// DestinyProgressionDefinition for caveats).
type DestinyProgressionStepDefinition struct {

    // Very rarely, Progressions will have localized text describing the Level of the progression.
    // This will be that localized text, if it exists. Otherwise, the standard appears to be to simply
    // show the level numerically.
    StepName string `json:"stepName"`


    // This appears to be, when you "level up", whether a visual effect will display and on what entity.
    // See DestinyProgressionStepDisplayEffect for slightly more info.
    DisplayEffectType DestinyProgressionStepDisplayEffect `json:"displayEffectType"`


    // The total amount of progression points/"experience" you will need to initially reach this
    // step. If this is the last step and the progression is repeating indefinitely
    // (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to
    // level it up further by repeating this step again.
    ProgressTotal int `json:"progressTotal"`


    // A listing of items rewarded as a result of reaching this level.
    RewardItems []DestinyItemQuantity `json:"rewardItems"`


    // If this progression step has a specific icon related to it, this is the icon to show.
    Icon string `json:"icon"`

}

