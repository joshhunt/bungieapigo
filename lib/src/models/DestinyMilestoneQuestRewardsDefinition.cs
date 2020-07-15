using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// If rewards are given in a quest - as opposed to overall in the entire Milestone - there&#39;s way less to track. We&#39;re going to simplify this contract as a result. However, this also gives us the opportunity to potentially put more than just item information into the reward data if we&#39;re able to mine it out in the future. Remember this if you come back and ask &quot;why are quest reward items nested inside of their own class?&quot;
	[DataContract]
	public class DestinyMilestoneQuestRewardsDefinition{

		/// <summary>
		/// The items that represent your reward for completing the quest.
		/// </summary>
		/// <summary>
		/// Be warned, these could be "dummy" items: items that are only used to render a good-looking in-game tooltip, but aren't the actual items themselves.
		/// </summary>
		/// <summary>
		/// For instance, when experience is given there's often a dummy item representing "experience", with quantity being the amount of experience you got. We don't have a programmatic association between those and whatever Progression is actually getting that experience... yet.
		/// </summary>
		[DataMember(Name="items", EmitDefaultValue=false)]
		public List<DestinyMilestoneQuestRewardItem> Items { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneQuestRewardsDefinition);
        }

		public bool Equals(DestinyMilestoneQuestRewardsDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) ;
		}
	}
}

