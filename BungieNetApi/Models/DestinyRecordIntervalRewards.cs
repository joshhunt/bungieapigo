using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordIntervalRewards
    {
        [DataMember(Name = "intervalRewardItems", EmitDefaultValue = false)]
        public List<DestinyItemQuantity> IntervalRewardItems { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordIntervalRewards);
        }

        public bool Equals(DestinyRecordIntervalRewards input)
        {
            if (input == null) return false;

            return
                (
                    IntervalRewardItems == input.IntervalRewardItems ||
                    (IntervalRewardItems != null && IntervalRewardItems.SequenceEqual(input.IntervalRewardItems))
                ) ;
        }
    }
}

