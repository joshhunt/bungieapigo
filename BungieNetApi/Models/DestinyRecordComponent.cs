using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordComponent
    {
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DestinyRecordState State { get; set; }

        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public List<DestinyObjectiveProgress> Objectives { get; set; }

        [DataMember(Name = "intervalObjectives", EmitDefaultValue = false)]
        public List<DestinyObjectiveProgress> IntervalObjectives { get; set; }

        [DataMember(Name = "intervalsRedeemedCount", EmitDefaultValue = false)]
        public long IntervalsRedeemedCount { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordComponent);
        }

        public bool Equals(DestinyRecordComponent input)
        {
            if (input == null) return false;

            return
                (
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) &&
                (
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.SequenceEqual(input.Objectives))
                ) &&
                (
                    IntervalObjectives == input.IntervalObjectives ||
                    (IntervalObjectives != null && IntervalObjectives.SequenceEqual(input.IntervalObjectives))
                ) &&
                (
                    IntervalsRedeemedCount == input.IntervalsRedeemedCount ||
                    (IntervalsRedeemedCount.Equals(input.IntervalsRedeemedCount))
                ) ;
        }
    }
}

