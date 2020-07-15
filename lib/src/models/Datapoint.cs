using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class Datapoint{

		/// <summary>
		/// Timestamp for the related count.
		/// </summary>
		[DataMember(Name="time", EmitDefaultValue=false)]
		public string Time { get; set; }

		/// <summary>
		/// Count associated with timestamp
		/// </summary>
		[DataMember(Name="count", EmitDefaultValue=false)]
		public double Count { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as Datapoint);
        }

		public bool Equals(Datapoint input)
		{
			if (input == null) return false;

			return
				(
                    Time == input.Time ||
                    (Time != null && Time.Equals(input.Time))
                ) &&
				(
                    Count == input.Count ||
                    (Count != null && Count.Equals(input.Count))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Time.GetHashCode();
				hashCode = hashCode * 59 + this.Count.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

