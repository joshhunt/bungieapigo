using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// A Milestone can have many Challenges. Challenges are just extra Objectives that provide a fun way to mix-up play and provide extra rewards.
	[DataContract]
	public class DestinyPublicMilestoneChallenge{

		/// <summary>
		/// The objective for the Challenge, which should have human-readable data about what needs to be done to accomplish the objective. Use this hash to look up the DestinyObjectiveDefinition.
		/// </summary>
		[DataMember(Name="objectiveHash", EmitDefaultValue=false)]
		public uint ObjectiveHash { get; set; }

		/// <summary>
		/// IF the Objective is related to a specific Activity, this will be that activity's hash. Use it to look up the DestinyActivityDefinition for additional data to show.
		/// </summary>
		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestoneChallenge);
        }

		public bool Equals(DestinyPublicMilestoneChallenge input)
		{
			if (input == null) return false;

			return
				(
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) ;
		}
	}
}

