using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the status and other related information for a challenge that is - or was - available to a player. 
    /// </summary>
    /// <summary>
    /// A challenge is a bonus objective, generally tacked onto Quests or Activities, that provide additional variations on play.
    /// </summary>
    [DataContract]
    public class DestinyChallengeStatus
    {
        /// <summary>
        /// The progress - including completion status - of the active challenge.
        /// </summary>
        [DataMember(Name = "objective", EmitDefaultValue = false)]
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
    }
}

