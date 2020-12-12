using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordCompletionBlock
    {
        /// <summary>
        /// The number of objectives that must be completed before the objective is considered "complete"
        /// </summary>
        [DataMember(Name = "partialCompletionObjectiveCountThreshold", EmitDefaultValue = false)]
        public long PartialCompletionObjectiveCountThreshold { get; set; }

        [DataMember(Name = "ScoreValue", EmitDefaultValue = false)]
        public long ScoreValue { get; set; }

        [DataMember(Name = "shouldFireToast", EmitDefaultValue = false)]
        public bool ShouldFireToast { get; set; }

        [DataMember(Name = "toastStyle", EmitDefaultValue = false)]
        public DestinyRecordToastStyle ToastStyle { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordCompletionBlock);
        }

        public bool Equals(DestinyRecordCompletionBlock input)
        {
            if (input == null) return false;

            return
                (
                    PartialCompletionObjectiveCountThreshold == input.PartialCompletionObjectiveCountThreshold ||
                    (PartialCompletionObjectiveCountThreshold.Equals(input.PartialCompletionObjectiveCountThreshold))
                ) &&
                (
                    ScoreValue == input.ScoreValue ||
                    (ScoreValue.Equals(input.ScoreValue))
                ) &&
                (
                    ShouldFireToast == input.ShouldFireToast ||
                    (ShouldFireToast != null && ShouldFireToast.Equals(input.ShouldFireToast))
                ) &&
                (
                    ToastStyle == input.ToastStyle ||
                    (ToastStyle != null && ToastStyle.Equals(input.ToastStyle))
                ) ;
        }
    }
}

