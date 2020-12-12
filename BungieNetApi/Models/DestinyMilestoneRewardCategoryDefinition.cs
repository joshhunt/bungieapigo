using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// The definition of a category of rewards, that contains many individual rewards.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneRewardCategoryDefinition
    {
        /// <summary>
        /// Identifies the reward category. Only guaranteed unique within this specific component!
        /// </summary>
        [DataMember(Name = "categoryHash", EmitDefaultValue = false)]
        public uint CategoryHash { get; set; }

        /// <summary>
        /// The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component.
        /// </summary>
        [DataMember(Name = "categoryIdentifier", EmitDefaultValue = false)]
        public string CategoryIdentifier { get; set; }

        /// <summary>
        /// Hopefully this is obvious by now.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we'll use at runtime to determine whether you've already earned or redeemed this set of rewards, and the category that this reward should be placed under.
        /// </summary>
        [DataMember(Name = "rewardEntries", EmitDefaultValue = false)]
        public Dictionary<string, DestinyMilestoneRewardEntryDefinition> RewardEntries { get; set; }

        /// <summary>
        /// If you want to use BNet's recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don't feel great about putting this here, I won't lie.
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public long Order { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneRewardCategoryDefinition);
        }

        public bool Equals(DestinyMilestoneRewardCategoryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    CategoryHash == input.CategoryHash ||
                    (CategoryHash.Equals(input.CategoryHash))
                ) &&
                (
                    CategoryIdentifier == input.CategoryIdentifier ||
                    (CategoryIdentifier != null && CategoryIdentifier.Equals(input.CategoryIdentifier))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    RewardEntries == input.RewardEntries ||
                    (RewardEntries != null && RewardEntries.SequenceEqual(input.RewardEntries))
                ) &&
                (
                    Order == input.Order ||
                    (Order.Equals(input.Order))
                ) ;
        }
    }
}

