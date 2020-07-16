using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordIntervalBlock
    {
        [DataMember(Name = "intervalObjectives", EmitDefaultValue = false)]
        public List<DestinyRecordIntervalObjective> IntervalObjectives { get; set; }

        [DataMember(Name = "originalObjectiveArrayInsertionIndex", EmitDefaultValue = false)]
        public long OriginalObjectiveArrayInsertionIndex { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordIntervalBlock);
        }

        public bool Equals(DestinyRecordIntervalBlock input)
        {
            if (input == null) return false;

            return
                (
                    IntervalObjectives == input.IntervalObjectives ||
                    (IntervalObjectives != null && IntervalObjectives.Equals(input.IntervalObjectives))
                ) &&
                (
                    OriginalObjectiveArrayInsertionIndex == input.OriginalObjectiveArrayInsertionIndex ||
                    (OriginalObjectiveArrayInsertionIndex != null && OriginalObjectiveArrayInsertionIndex.Equals(input.OriginalObjectiveArrayInsertionIndex))
                ) ;
        }
    }
}

