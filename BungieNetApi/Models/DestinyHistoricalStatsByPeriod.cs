using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalStatsByPeriod
    {
        [DataMember(Name = "allTime", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTime { get; set; }

        [DataMember(Name = "allTimeTier1", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier1 { get; set; }

        [DataMember(Name = "allTimeTier2", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier2 { get; set; }

        [DataMember(Name = "allTimeTier3", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier3 { get; set; }

        [DataMember(Name = "daily", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsPeriodGroup> Daily { get; set; }

        [DataMember(Name = "monthly", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsPeriodGroup> Monthly { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsByPeriod);
        }

        public bool Equals(DestinyHistoricalStatsByPeriod input)
        {
            if (input == null) return false;

            return
                (
                    AllTime == input.AllTime ||
                    (AllTime != null && AllTime.SequenceEqual(input.AllTime))
                ) &&
                (
                    AllTimeTier1 == input.AllTimeTier1 ||
                    (AllTimeTier1 != null && AllTimeTier1.SequenceEqual(input.AllTimeTier1))
                ) &&
                (
                    AllTimeTier2 == input.AllTimeTier2 ||
                    (AllTimeTier2 != null && AllTimeTier2.SequenceEqual(input.AllTimeTier2))
                ) &&
                (
                    AllTimeTier3 == input.AllTimeTier3 ||
                    (AllTimeTier3 != null && AllTimeTier3.SequenceEqual(input.AllTimeTier3))
                ) &&
                (
                    Daily == input.Daily ||
                    (Daily != null && Daily.SequenceEqual(input.Daily))
                ) &&
                (
                    Monthly == input.Monthly ||
                    (Monthly != null && Monthly.SequenceEqual(input.Monthly))
                ) ;
        }
    }
}

