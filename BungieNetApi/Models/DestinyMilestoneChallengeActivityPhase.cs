using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyMilestoneChallengeActivityPhase{

		/// <summary>
		/// The hash identifier of the activity's phase.
		/// </summary>
		[DataMember(Name="phaseHash", EmitDefaultValue=false)]
		public uint PhaseHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeActivityPhase);
        }

		public bool Equals(DestinyMilestoneChallengeActivityPhase input)
		{
			if (input == null) return false;

			return
				(
                    PhaseHash == input.PhaseHash ||
                    (PhaseHash != null && PhaseHash.Equals(input.PhaseHash))
                ) ;
		}
	}
}

