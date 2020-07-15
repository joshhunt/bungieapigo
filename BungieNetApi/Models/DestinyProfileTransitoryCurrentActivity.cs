using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// If you are playing in an activity, this is some information about it.
    /// </summary>
    /// <summary>
    /// Note that we cannot guarantee any of this resembles what ends up in the PGCR in any way. They are sourced by two entirely separate systems with their own logic, and the one we source this data from should be considered non-authoritative in comparison.
    /// </summary>
    [DataContract]
    public class DestinyProfileTransitoryCurrentActivity
    {
        /// <summary>
        /// When the activity started.
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// If you're still in it but it "ended" (like when folks are dancing around the loot after they beat a boss), this is when the activity ended.
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This is what our non-authoritative source thought the score was.
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public double Score { get; set; }

        /// <summary>
        /// If you have human opponents, this is the highest opposing team's score.
        /// </summary>
        [DataMember(Name = "highestOpposingFactionScore", EmitDefaultValue = false)]
        public double HighestOpposingFactionScore { get; set; }

        /// <summary>
        /// This is how many human or poorly crafted aimbot opponents you have.
        /// </summary>
        [DataMember(Name = "numberOfOpponents", EmitDefaultValue = false)]
        public long NumberOfOpponents { get; set; }

        /// <summary>
        /// This is how many human or poorly crafted aimbots are on your team.
        /// </summary>
        [DataMember(Name = "numberOfPlayers", EmitDefaultValue = false)]
        public long NumberOfPlayers { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileTransitoryCurrentActivity);
        }

        public bool Equals(DestinyProfileTransitoryCurrentActivity input)
        {
            if (input == null) return false;

            return
                (
                    StartTime == input.StartTime ||
                    (StartTime != null && StartTime.Equals(input.StartTime))
                ) &&
                (
                    EndTime == input.EndTime ||
                    (EndTime != null && EndTime.Equals(input.EndTime))
                ) &&
                (
                    Score == input.Score ||
                    (Score != null && Score.Equals(input.Score))
                ) &&
                (
                    HighestOpposingFactionScore == input.HighestOpposingFactionScore ||
                    (HighestOpposingFactionScore != null && HighestOpposingFactionScore.Equals(input.HighestOpposingFactionScore))
                ) &&
                (
                    NumberOfOpponents == input.NumberOfOpponents ||
                    (NumberOfOpponents != null && NumberOfOpponents.Equals(input.NumberOfOpponents))
                ) &&
                (
                    NumberOfPlayers == input.NumberOfPlayers ||
                    (NumberOfPlayers != null && NumberOfPlayers.Equals(input.NumberOfPlayers))
                ) ;
        }
    }
}

