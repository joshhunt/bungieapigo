using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyRecordIntervalObjective{

		[DataMember(Name="intervalObjectiveHash", EmitDefaultValue=false)]
		public uint IntervalObjectiveHash { get; set; }

		[DataMember(Name="intervalScoreValue", EmitDefaultValue=false)]
		public long IntervalScoreValue { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordIntervalObjective);
        }

		public bool Equals(DestinyRecordIntervalObjective input)
		{
			if (input == null) return false;

			return
				(
                    IntervalObjectiveHash == input.IntervalObjectiveHash ||
                    (IntervalObjectiveHash != null && IntervalObjectiveHash.Equals(input.IntervalObjectiveHash))
                ) &&
				(
                    IntervalScoreValue == input.IntervalScoreValue ||
                    (IntervalScoreValue != null && IntervalScoreValue.Equals(input.IntervalScoreValue))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.IntervalObjectiveHash.GetHashCode();
				hashCode = hashCode * 59 + this.IntervalScoreValue.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

