using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character's progress in it.
    /// </summary>
    [DataContract]
    public class DestinyPublicActivityStatus
    {
        /// <summary>
        /// Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.
        /// </summary>
        [DataMember(Name = "challengeObjectiveHashes", EmitDefaultValue = false)]
        public List<uint> ChallengeObjectiveHashes { get; set; }

        /// <summary>
        /// The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.
        /// </summary>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<uint> ModifierHashes { get; set; }

        /// <summary>
        /// If the activity itself provides any specific "mock" rewards, this will be the items and their quantity.
        /// </summary>
        /// <summary>
        /// Why "mock", you ask? Because these are the rewards as they are represented in the tooltip of the Activity.
        /// </summary>
        /// <summary>
        /// These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.
        /// </summary>
        [DataMember(Name = "rewardTooltipItems", EmitDefaultValue = false)]
        public List<DestinyItemQuantity> RewardTooltipItems { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicActivityStatus);
        }

        public bool Equals(DestinyPublicActivityStatus input)
        {
            if (input == null) return false;

            return
                (
                    ChallengeObjectiveHashes == input.ChallengeObjectiveHashes ||
                    (ChallengeObjectiveHashes != null && ChallengeObjectiveHashes.Equals(input.ChallengeObjectiveHashes))
                ) &&
                (
                    ModifierHashes == input.ModifierHashes ||
                    (ModifierHashes != null && ModifierHashes.Equals(input.ModifierHashes))
                ) &&
                (
                    RewardTooltipItems == input.RewardTooltipItems ||
                    (RewardTooltipItems != null && RewardTooltipItems.Equals(input.RewardTooltipItems))
                ) ;
        }
    }
}

