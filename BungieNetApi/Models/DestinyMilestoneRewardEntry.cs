using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The character-specific data for a milestone's reward entry. See DestinyMilestoneDefinition for more information about Reward Entries.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneRewardEntry
    {
        /// <summary>
        /// The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone's DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.
        /// </summary>
        [DataMember(Name = "rewardEntryHash", EmitDefaultValue = false)]
        public uint RewardEntryHash { get; set; }

        /// <summary>
        /// If TRUE, the player has earned this reward.
        /// </summary>
        [DataMember(Name = "earned", EmitDefaultValue = false)]
        public bool Earned { get; set; }

        /// <summary>
        /// If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to "gotTheShinyBauble" in your own codebase.
        /// </summary>
        [DataMember(Name = "redeemed", EmitDefaultValue = false)]
        public bool Redeemed { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneRewardEntry);
        }

        public bool Equals(DestinyMilestoneRewardEntry input)
        {
            if (input == null) return false;

            return
                (
                    RewardEntryHash == input.RewardEntryHash ||
                    (RewardEntryHash != null && RewardEntryHash.Equals(input.RewardEntryHash))
                ) &&
                (
                    Earned == input.Earned ||
                    (Earned != null && Earned.Equals(input.Earned))
                ) &&
                (
                    Redeemed == input.Redeemed ||
                    (Redeemed != null && Redeemed.Equals(input.Redeemed))
                ) ;
        }
    }
}

