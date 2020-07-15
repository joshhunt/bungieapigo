using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyRecordIntervalBlock{

		[DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
		public List<DestinyRecordIntervalObjective> IntervalObjectives { get; set; }

		[DataMember(Name="originalObjectiveArrayInsertionIndex", EmitDefaultValue=false)]
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.IntervalObjectives.GetHashCode();
				hashCode = hashCode * 59 + this.OriginalObjectiveArrayInsertionIndex.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

