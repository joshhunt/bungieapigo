using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// An item can have objectives on it. In practice, these are the exclusive purview of "Quest Step" items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.
    /// </summary>
    /// <summary>
    /// Quest steps have 1:M objectives that we end up processing and returning in live data as DestinyQuestStatus data, and other useful information.
    /// </summary>
    [DataContract]
    public class DestinyItemObjectiveBlockDefinition
    {
        /// <summary>
        /// The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.
        /// </summary>
        [DataMember(Name = "objectiveHashes", EmitDefaultValue = false)]
        public List<uint> ObjectiveHashes { get; set; }

        /// <summary>
        /// For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).
        /// </summary>
        /// <summary>
        /// Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.
        /// </summary>
        [DataMember(Name = "displayActivityHashes", EmitDefaultValue = false)]
        public List<uint> DisplayActivityHashes { get; set; }

        /// <summary>
        /// If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.
        /// </summary>
        [DataMember(Name = "requireFullObjectiveCompletion", EmitDefaultValue = false)]
        public bool RequireFullObjectiveCompletion { get; set; }

        /// <summary>
        /// The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
        /// </summary>
        [DataMember(Name = "questlineItemHash", EmitDefaultValue = false)]
        public uint QuestlineItemHash { get; set; }

        /// <summary>
        /// The localized string for narrative text related to this quest step, if any.
        /// </summary>
        [DataMember(Name = "narrative", EmitDefaultValue = false)]
        public string Narrative { get; set; }

        /// <summary>
        /// The localized string describing an action to be performed associated with the objectives, if any.
        /// </summary>
        [DataMember(Name = "objectiveVerbName", EmitDefaultValue = false)]
        public string ObjectiveVerbName { get; set; }

        /// <summary>
        /// The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.
        /// </summary>
        [DataMember(Name = "questTypeIdentifier", EmitDefaultValue = false)]
        public string QuestTypeIdentifier { get; set; }

        /// <summary>
        /// A hashed value for the questTypeIdentifier, because apparently I like to be redundant.
        /// </summary>
        [DataMember(Name = "questTypeHash", EmitDefaultValue = false)]
        public uint QuestTypeHash { get; set; }

        /// <summary>
        /// One entry per Objective on the item, it will have related display information.
        /// </summary>
        [DataMember(Name = "perObjectiveDisplayProperties", EmitDefaultValue = false)]
        public List<DestinyObjectiveDisplayProperties> PerObjectiveDisplayProperties { get; set; }

        [DataMember(Name = "displayAsStatTracker", EmitDefaultValue = false)]
        public bool DisplayAsStatTracker { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemObjectiveBlockDefinition);
        }

        public bool Equals(DestinyItemObjectiveBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ObjectiveHashes == input.ObjectiveHashes ||
                    (ObjectiveHashes != null && ObjectiveHashes.Equals(input.ObjectiveHashes))
                ) &&
                (
                    DisplayActivityHashes == input.DisplayActivityHashes ||
                    (DisplayActivityHashes != null && DisplayActivityHashes.Equals(input.DisplayActivityHashes))
                ) &&
                (
                    RequireFullObjectiveCompletion == input.RequireFullObjectiveCompletion ||
                    (RequireFullObjectiveCompletion != null && RequireFullObjectiveCompletion.Equals(input.RequireFullObjectiveCompletion))
                ) &&
                (
                    QuestlineItemHash == input.QuestlineItemHash ||
                    (QuestlineItemHash != null && QuestlineItemHash.Equals(input.QuestlineItemHash))
                ) &&
                (
                    Narrative == input.Narrative ||
                    (Narrative != null && Narrative.Equals(input.Narrative))
                ) &&
                (
                    ObjectiveVerbName == input.ObjectiveVerbName ||
                    (ObjectiveVerbName != null && ObjectiveVerbName.Equals(input.ObjectiveVerbName))
                ) &&
                (
                    QuestTypeIdentifier == input.QuestTypeIdentifier ||
                    (QuestTypeIdentifier != null && QuestTypeIdentifier.Equals(input.QuestTypeIdentifier))
                ) &&
                (
                    QuestTypeHash == input.QuestTypeHash ||
                    (QuestTypeHash != null && QuestTypeHash.Equals(input.QuestTypeHash))
                ) &&
                (
                    PerObjectiveDisplayProperties == input.PerObjectiveDisplayProperties ||
                    (PerObjectiveDisplayProperties != null && PerObjectiveDisplayProperties.Equals(input.PerObjectiveDisplayProperties))
                ) &&
                (
                    DisplayAsStatTracker == input.DisplayAsStatTracker ||
                    (DisplayAsStatTracker != null && DisplayAsStatTracker.Equals(input.DisplayAsStatTracker))
                ) ;
        }
    }
}

