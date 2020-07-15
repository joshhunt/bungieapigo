using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class InterpolationPoint
    {
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public long Value { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public long Weight { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as InterpolationPoint);
        }

        public bool Equals(InterpolationPoint input)
        {
            if (input == null) return false;

            return
                (
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) &&
                (
                    Weight == input.Weight ||
                    (Weight != null && Weight.Equals(input.Weight))
                ) ;
        }
    }
}

