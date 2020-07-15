using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents the status and other related information for a challenge that is - or was - available to a player. 
	/// A challenge is a bonus objective, generally tacked onto Quests or Activities, that provide additional variations on play.
	[DataContract]
	public class DestinyChallengeStatus{

		/// <summary>
		/// The progress - including completion status - of the active challenge.
		/// </summary>
		[DataMember(Name="objective", EmitDefaultValue=false)]
		public DestinyObjectiveProgress Objective { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyChallengeStatus);
        }

		public bool Equals(DestinyChallengeStatus input)
		{
			if (input == null) return false;

			return
				(
                    Objective == input.Objective ||
                    (Objective != null && Objective.Equals(input.Objective))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Objective.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

