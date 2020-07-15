using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyMilestoneChallengeDefinition{

		/// <summary>
		/// The challenge related to this milestone.
		/// </summary>
		[DataMember(Name="challengeObjectiveHash", EmitDefaultValue=false)]
		public uint ChallengeObjectiveHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeDefinition);
        }

		public bool Equals(DestinyMilestoneChallengeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ChallengeObjectiveHash == input.ChallengeObjectiveHash ||
                    (ChallengeObjectiveHash != null && ChallengeObjectiveHash.Equals(input.ChallengeObjectiveHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ChallengeObjectiveHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

