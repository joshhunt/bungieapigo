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

        /// <summary>
        /// If available, this is the number of times this record has been completed. For example, the number of times a seal title has been gilded.
        /// </summary>
        [DataMember(Name = "completedCount", EmitDefaultValue = false)]
        public long CompletedCount { get; set; }

        /// <summary>
        /// If available, a list that describes which reward rewards should be shown (true) or hidden (false). This property is for regular record rewards, and not for interval objective rewards.
        /// </summary>
        [DataMember(Name = "rewardVisibilty", EmitDefaultValue = false)]
        public List<bool> RewardVisibilty { get; set; }


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
                ) &&
                (
                    CompletedCount == input.CompletedCount ||
                    (CompletedCount.Equals(input.CompletedCount))
                ) &&
                (
                    RewardVisibilty == input.RewardVisibilty ||
                    (RewardVisibilty != null && RewardVisibilty.SequenceEqual(input.RewardVisibilty))
                ) ;
        }
    }
}

