using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class InterpolationPoint{

		[DataMember(Name="value", EmitDefaultValue=false)]
		public long Value { get; set; }

		[DataMember(Name="weight", EmitDefaultValue=false)]
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Value.GetHashCode();
				hashCode = hashCode * 59 + this.Weight.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

