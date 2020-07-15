using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents a category of "summary" rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneRewardCategory{

		/// <summary>
		/// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
		/// </summary>
		[DataMember(Name="rewardCategoryHash", EmitDefaultValue=false)]
		public uint RewardCategoryHash { get; set; }

		/// <summary>
		/// The individual reward entries for this category, and their status.
		/// </summary>
		[DataMember(Name="entries", EmitDefaultValue=false)]
		public List<DestinyMilestoneRewardEntry> Entries { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneRewardCategory);
        }

		public bool Equals(DestinyMilestoneRewardCategory input)
		{
			if (input == null) return false;

			return
				(
                    RewardCategoryHash == input.RewardCategoryHash ||
                    (RewardCategoryHash != null && RewardCategoryHash.Equals(input.RewardCategoryHash))
                ) &&
				(
                    Entries == input.Entries ||
                    (Entries != null && Entries.Equals(input.Entries))
                ) ;
		}
	}
}

