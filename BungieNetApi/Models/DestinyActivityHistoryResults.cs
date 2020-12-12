using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyActivityHistoryResults
    {
        /// <summary>
        /// List of activities, the most recent activity first.
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsPeriodGroup> Activities { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityHistoryResults);
        }

        public bool Equals(DestinyActivityHistoryResults input)
        {
            if (input == null) return false;

            return
                (
                    Activities == input.Activities ||
                    (Activities != null && Activities.SequenceEqual(input.Activities))
                ) ;
        }
    }
}

