using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyPublicMilestoneQuest{

		/// <summary>
		/// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
		/// </summary>
		[DataMember(Name="questItemHash", EmitDefaultValue=false)]
		public uint QuestItemHash { get; set; }

		/// <summary>
		/// A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.
		/// </summary>
		[DataMember(Name="activity", EmitDefaultValue=false)]
		public DestinyPublicMilestoneActivity Activity { get; set; }

		/// <summary>
		/// For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.
		/// </summary>
		[DataMember(Name="challenges", EmitDefaultValue=false)]
		public List<DestinyPublicMilestoneChallenge> Challenges { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestoneQuest);
        }

		public bool Equals(DestinyPublicMilestoneQuest input)
		{
			if (input == null) return false;

			return
				(
                    QuestItemHash == input.QuestItemHash ||
                    (QuestItemHash != null && QuestItemHash.Equals(input.QuestItemHash))
                ) &&
				(
                    Activity == input.Activity ||
                    (Activity != null && Activity.Equals(input.Activity))
                ) &&
				(
                    Challenges == input.Challenges ||
                    (Challenges != null && Challenges.Equals(input.Challenges))
                ) ;
		}
	}
}

