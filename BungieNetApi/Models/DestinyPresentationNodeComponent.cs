using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyPresentationNodeComponent
    {
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DestinyPresentationNodeState State { get; set; }

        /// <summary>
        /// An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes.
        /// </summary>
        [DataMember(Name = "objective", EmitDefaultValue = false)]
        public DestinyObjectiveProgress Objective { get; set; }

        /// <summary>
        /// How much of the presentation node is considered to be completed so far by the given character/profile.
        /// </summary>
        [DataMember(Name = "progressValue", EmitDefaultValue = false)]
        public long ProgressValue { get; set; }

        /// <summary>
        /// The value at which the presentation node is considered to be completed.
        /// </summary>
        [DataMember(Name = "completionValue", EmitDefaultValue = false)]
        public long CompletionValue { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeComponent);
        }

        public bool Equals(DestinyPresentationNodeComponent input)
        {
            if (input == null) return false;

            return
                (
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) &&
                (
                    Objective == input.Objective ||
                    (Objective != null && Objective.Equals(input.Objective))
                ) &&
                (
                    ProgressValue == input.ProgressValue ||
                    (ProgressValue != null && ProgressValue.Equals(input.ProgressValue))
                ) &&
                (
                    CompletionValue == input.CompletionValue ||
                    (CompletionValue != null && CompletionValue.Equals(input.CompletionValue))
                ) ;
        }
    }
}

