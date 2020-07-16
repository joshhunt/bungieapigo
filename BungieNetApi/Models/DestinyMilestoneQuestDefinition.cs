using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// Any data we need to figure out whether this Quest Item is the currently active one for the conceptual Milestone. Even just typing this description, I already regret it.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneQuestDefinition
    {
        /// <summary>
        /// The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.
        /// </summary>
        [DataMember(Name = "questItemHash", EmitDefaultValue = false)]
        public uint QuestItemHash { get; set; }

        /// <summary>
        /// The individual quests may have different definitions from the overall milestone: if there's a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If populated, this image can be shown instead of the generic milestone's image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.
        /// </summary>
        [DataMember(Name = "overrideImage", EmitDefaultValue = false)]
        public string OverrideImage { get; set; }

        /// <summary>
        /// The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it'll be a decent amount of data. Sometimes, it's going to be sucky. Sorry.
        /// </summary>
        [DataMember(Name = "questRewards", EmitDefaultValue = false)]
        public DestinyMilestoneQuestRewardsDefinition QuestRewards { get; set; }

        /// <summary>
        /// The full set of all possible "conceptual activities" that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public Dictionary<string, DestinyMilestoneActivityDefinition> Activities { get; set; }

        /// <summary>
        /// Sometimes, a Milestone's quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future.
        /// </summary>
        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public uint DestinationHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneQuestDefinition);
        }

        public bool Equals(DestinyMilestoneQuestDefinition input)
        {
            if (input == null) return false;

            return
                (
                    QuestItemHash == input.QuestItemHash ||
                    (QuestItemHash != null && QuestItemHash.Equals(input.QuestItemHash))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    OverrideImage == input.OverrideImage ||
                    (OverrideImage != null && OverrideImage.Equals(input.OverrideImage))
                ) &&
                (
                    QuestRewards == input.QuestRewards ||
                    (QuestRewards != null && QuestRewards.Equals(input.QuestRewards))
                ) &&
                (
                    Activities == input.Activities ||
                    (Activities != null && Activities.Equals(input.Activities))
                ) &&
                (
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) ;
        }
    }
}

