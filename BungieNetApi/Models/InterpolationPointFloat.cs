using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class InterpolationPointFloat{

		[DataMember(Name="value", EmitDefaultValue=false)]
		public double Value { get; set; }

		[DataMember(Name="weight", EmitDefaultValue=false)]
		public double Weight { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as InterpolationPointFloat);
        }

		public bool Equals(InterpolationPointFloat input)
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

