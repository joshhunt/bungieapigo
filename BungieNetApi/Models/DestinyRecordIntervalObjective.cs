using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyRecordIntervalObjective
    {
        [DataMember(Name = "intervalObjectiveHash", EmitDefaultValue = false)]
        public uint IntervalObjectiveHash { get; set; }

        [DataMember(Name = "intervalScoreValue", EmitDefaultValue = false)]
        public long IntervalScoreValue { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordIntervalObjective);
        }

        public bool Equals(DestinyRecordIntervalObjective input)
        {
            if (input == null) return false;

            return
                (
                    IntervalObjectiveHash == input.IntervalObjectiveHash ||
                    (IntervalObjectiveHash != null && IntervalObjectiveHash.Equals(input.IntervalObjectiveHash))
                ) &&
                (
                    IntervalScoreValue == input.IntervalScoreValue ||
                    (IntervalScoreValue != null && IntervalScoreValue.Equals(input.IntervalScoreValue))
                ) ;
        }
    }
}

