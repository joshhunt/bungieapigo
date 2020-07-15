using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DateRange{

		[DataMember(Name="start", EmitDefaultValue=false)]
		public string Start { get; set; }

		[DataMember(Name="end", EmitDefaultValue=false)]
		public string End { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DateRange);
        }

		public bool Equals(DateRange input)
		{
			if (input == null) return false;

			return
				(
                    Start == input.Start ||
                    (Start != null && Start.Equals(input.Start))
                ) &&
				(
                    End == input.End ||
                    (End != null && End.Equals(input.End))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Start.GetHashCode();
				hashCode = hashCode * 59 + this.End.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

