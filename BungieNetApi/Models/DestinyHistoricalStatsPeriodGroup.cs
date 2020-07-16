using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalStatsPeriodGroup
    {
        /// <summary>
        /// Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is 'all time'.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public DateTime Period { get; set; }

        /// <summary>
        /// If the period group is for a specific activity, this property will be set.
        /// </summary>
        [DataMember(Name = "activityDetails", EmitDefaultValue = false)]
        public DestinyHistoricalStatsActivity ActivityDetails { get; set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsPeriodGroup);
        }

        public bool Equals(DestinyHistoricalStatsPeriodGroup input)
        {
            if (input == null) return false;

            return
                (
                    Period == input.Period ||
                    (Period != null && Period.Equals(input.Period))
                ) &&
                (
                    ActivityDetails == input.ActivityDetails ||
                    (ActivityDetails != null && ActivityDetails.Equals(input.ActivityDetails))
                ) &&
                (
                    Values == input.Values ||
                    (Values != null && Values.Equals(input.Values))
                ) ;
        }
    }
}

