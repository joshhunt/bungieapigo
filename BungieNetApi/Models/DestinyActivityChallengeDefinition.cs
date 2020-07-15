using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents a reference to a Challenge, which for now is just an Objective.
	/// </summary>
	[DataContract]
	public class DestinyActivityChallengeDefinition{

		/// <summary>
		/// The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.
		/// </summary>
		[DataMember(Name="objectiveHash", EmitDefaultValue=false)]
		public uint ObjectiveHash { get; set; }

		/// <summary>
		/// The rewards as they're represented in the UI. Note that they generally link to "dummy" items that give a summary of rewards rather than direct, real items themselves.
		/// </summary>
		/// <summary>
		/// If the quantity is 0, don't show the quantity.
		/// </summary>
		[DataMember(Name="dummyRewards", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> DummyRewards { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityChallengeDefinition);
        }

		public bool Equals(DestinyActivityChallengeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
				(
                    DummyRewards == input.DummyRewards ||
                    (DummyRewards != null && DummyRewards.Equals(input.DummyRewards))
                ) ;
		}
	}
}

