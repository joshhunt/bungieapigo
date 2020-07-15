using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyPostGameCarnageReportEntry
    {
        /// <summary>
        /// Standing of the player
        /// </summary>
        [DataMember(Name = "standing", EmitDefaultValue = false)]
        public long Standing { get; set; }

        /// <summary>
        /// Score of the player if available
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public DestinyHistoricalStatsValue Score { get; set; }

        /// <summary>
        /// Identity details of the player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public DestinyPlayer Player { get; set; }

        /// <summary>
        /// ID of the player's character used in the activity.
        /// </summary>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }

        /// <summary>
        /// Extended data extracted from the activity blob.
        /// </summary>
        [DataMember(Name = "extended", EmitDefaultValue = false)]
        public DestinyPostGameCarnageReportExtendedData Extended { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPostGameCarnageReportEntry);
        }

        public bool Equals(DestinyPostGameCarnageReportEntry input)
        {
            if (input == null) return false;

            return
                (
                    Standing == input.Standing ||
                    (Standing != null && Standing.Equals(input.Standing))
                ) &&
                (
                    Score == input.Score ||
                    (Score != null && Score.Equals(input.Score))
                ) &&
                (
                    Player == input.Player ||
                    (Player != null && Player.Equals(input.Player))
                ) &&
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
                (
                    Values == input.Values ||
                    (Values != null && Values.Equals(input.Values))
                ) &&
                (
                    Extended == input.Extended ||
                    (Extended != null && Extended.Equals(input.Extended))
                ) ;
        }
    }
}

