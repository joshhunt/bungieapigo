using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.
	[DataContract]
	public class DestinyItemObjectivesComponent{

		/// <summary>
		/// If the item has a hard association with objectives, your progress on them will be defined here. 
		/// </summary>
		/// <summary>
		/// Objectives are our standard way to describe a series of tasks that have to be completed for a reward.
		/// </summary>
		[DataMember(Name="objectives", EmitDefaultValue=false)]
		public List<DestinyObjectiveProgress> Objectives { get; set; }

		/// <summary>
		/// I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for "flavor" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
		/// </summary>
		[DataMember(Name="flavorObjective", EmitDefaultValue=false)]
		public DestinyObjectiveProgress FlavorObjective { get; set; }

		/// <summary>
		/// If we have any information on when these objectives were completed, this will be the date of that completion. This won't be on many items, but could be interesting for some items that do store this information.
		/// </summary>
		[DataMember(Name="dateCompleted", EmitDefaultValue=false)]
		public string DateCompleted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemObjectivesComponent);
        }

		public bool Equals(DestinyItemObjectivesComponent input)
		{
			if (input == null) return false;

			return
				(
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) &&
				(
                    FlavorObjective == input.FlavorObjective ||
                    (FlavorObjective != null && FlavorObjective.Equals(input.FlavorObjective))
                ) &&
				(
                    DateCompleted == input.DateCompleted ||
                    (DateCompleted != null && DateCompleted.Equals(input.DateCompleted))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Objectives.GetHashCode();
				hashCode = hashCode * 59 + this.FlavorObjective.GetHashCode();
				hashCode = hashCode * 59 + this.DateCompleted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

