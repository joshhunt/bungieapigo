using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyLeaderboardResults
    {
        /// <summary>
        /// Indicate the membership ID of the account that is the focal point of the provided leaderboards.
        /// </summary>
        [DataMember(Name = "focusMembershipId", EmitDefaultValue = false)]
        public long FocusMembershipId { get; set; }

        /// <summary>
        /// Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.
        /// </summary>
        [DataMember(Name = "focusCharacterId", EmitDefaultValue = false)]
        public long FocusCharacterId { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLeaderboardResults);
        }

        public bool Equals(DestinyLeaderboardResults input)
        {
            if (input == null) return false;

            return
                (
                    FocusMembershipId == input.FocusMembershipId ||
                    (FocusMembershipId != null && FocusMembershipId.Equals(input.FocusMembershipId))
                ) &&
                (
                    FocusCharacterId == input.FocusCharacterId ||
                    (FocusCharacterId != null && FocusCharacterId.Equals(input.FocusCharacterId))
                ) ;
        }
    }
}

