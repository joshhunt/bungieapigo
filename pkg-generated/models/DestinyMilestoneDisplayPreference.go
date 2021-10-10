package bungieapigo

// A hint for the UI as to what display information ought to be shown. Defaults to showing the static
// MilestoneDefinition's display properties.
//  If for some reason the indicated property is not populated, fall back to the
// MilestoneDefinition.displayProperties.
type DestinyMilestoneDisplayPreference int

const (

    // Indicates you should show DestinyMilestoneDefinition.displayProperties for this
    // Milestone.
    DestinyMilestoneDisplayPreferenceMilestoneDefinition = 0


    // Indicates you should show the displayProperties for any currently active Quest Steps in
    // DestinyMilestone.availableQuests.
    DestinyMilestoneDisplayPreferenceCurrentQuestSteps = 1


    // Indicates you should show the displayProperties for any currently active Activities and
    // their Challenges in DestinyMilestone.activities.
    DestinyMilestoneDisplayPreferenceCurrentActivityChallenges = 2

)