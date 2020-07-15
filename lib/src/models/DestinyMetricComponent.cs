using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyMetricComponent{

		[DataMember(Name="invisible", EmitDefaultValue=false)]
		public bool Invisible { get; set; }

		/// <summary>
		/// Returns data about a character's status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
		/// </summary>
		[DataMember(Name="objectiveProgress", EmitDefaultValue=false)]
		public DestinyObjectiveProgress ObjectiveProgress { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMetricComponent);
        }

		public bool Equals(DestinyMetricComponent input)
		{
			if (input == null) return false;

			return
				(
                    Invisible == input.Invisible ||
                    (Invisible != null && Invisible.Equals(input.Invisible))
                ) &&
				(
                    ObjectiveProgress == input.ObjectiveProgress ||
                    (ObjectiveProgress != null && ObjectiveProgress.Equals(input.ObjectiveProgress))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Invisible.GetHashCode();
				hashCode = hashCode * 59 + this.ObjectiveProgress.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

