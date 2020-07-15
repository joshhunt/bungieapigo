using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyMilestoneChallengeActivityDefinition
    {
        /// <summary>
        /// The activity for which this challenge is active.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        public List<DestinyMilestoneChallengeDefinition> Challenges { get; set; }

        /// <summary>
        /// If the activity and its challenge is visible on any of these nodes, it will be returned.
        /// </summary>
        [DataMember(Name = "activityGraphNodes", EmitDefaultValue = false)]
        public List<DestinyMilestoneChallengeActivityGraphNodeEntry> ActivityGraphNodes { get; set; }

        /// <summary>
        /// Phases related to this activity, if there are any.
        /// </summary>
        /// <summary>
        /// These will be listed in the order in which they will appear in the actual activity.
        /// </summary>
        [DataMember(Name = "phases", EmitDefaultValue = false)]
        public List<DestinyMilestoneChallengeActivityPhase> Phases { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeActivityDefinition);
        }

        public bool Equals(DestinyMilestoneChallengeActivityDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    Challenges == input.Challenges ||
                    (Challenges != null && Challenges.Equals(input.Challenges))
                ) &&
                (
                    ActivityGraphNodes == input.ActivityGraphNodes ||
                    (ActivityGraphNodes != null && ActivityGraphNodes.Equals(input.ActivityGraphNodes))
                ) &&
                (
                    Phases == input.Phases ||
                    (Phases != null && Phases.Equals(input.Phases))
                ) ;
        }
    }
}

