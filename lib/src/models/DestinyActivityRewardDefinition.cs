using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Activities can refer to one or more sets of tooltip-friendly reward data. These are the definitions for those tooltip friendly rewards.
	[DataContract]
	public class DestinyActivityRewardDefinition{

		/// <summary>
		/// The header for the reward set, if any.
		/// </summary>
		[DataMember(Name="rewardText", EmitDefaultValue=false)]
		public string RewardText { get; set; }

		/// <summary>
		/// The "Items provided" in the reward. This is almost always a pointer to a DestinyInventoryItemDefintion for an item that you can't actually earn in-game, but that has name/description/icon information for the vague concept of the rewards you will receive. This is because the actual reward generation is non-deterministic and extremely complicated, so the best the game can do is tell you what you'll get in vague terms. And so too shall we.
		/// </summary>
		/// <summary>
		/// Interesting trivia: you actually *do* earn these items when you complete the activity. They go into a single-slot bucket on your profile, which is how you see the pop-ups of these rewards when you complete an activity that match these "dummy" items. You can even see them if you look at the last one you earned in your profile-level inventory through the BNet API! Who said reading documentation is a waste of time?
		/// </summary>
		[DataMember(Name="rewardItems", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> RewardItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityRewardDefinition);
        }

		public bool Equals(DestinyActivityRewardDefinition input)
		{
			if (input == null) return false;

			return
				(
                    RewardText == input.RewardText ||
                    (RewardText != null && RewardText.Equals(input.RewardText))
                ) &&
				(
                    RewardItems == input.RewardItems ||
                    (RewardItems != null && RewardItems.Equals(input.RewardItems))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.RewardText.GetHashCode();
				hashCode = hashCode * 59 + this.RewardItems.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

