using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// A hint for the UI as to what display information ought to be shown. Defaults to showing the static MilestoneDefinition's display properties.
    /// </summary>
    /// <summary>
    ///  If for some reason the indicated property is not populated, fall back to the MilestoneDefinition.displayProperties.
    /// </summary>
    
    public enum DestinyMilestoneDisplayPreference
    {
        /// <summary>
        /// MilestoneDefinition = 0
        /// Indicates you should show DestinyMilestoneDefinition.displayProperties for this Milestone.
        /// </summary>
        [EnumMember(Value = "0")]
        MilestoneDefinition = 0,

        /// <summary>
        /// CurrentQuestSteps = 1
        /// Indicates you should show the displayProperties for any currently active Quest Steps in DestinyMilestone.availableQuests.
        /// </summary>
        [EnumMember(Value = "1")]
        CurrentQuestSteps = 1,

        /// <summary>
        /// CurrentActivityChallenges = 2
        /// Indicates you should show the displayProperties for any currently active Activities and their Challenges in DestinyMilestone.activities.
        /// </summary>
        [EnumMember(Value = "2")]
        CurrentActivityChallenges = 2,

    }
}