using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents a variant of an activity that&#39;s relevant to a milestone.
	[DataContract]
	public class DestinyPublicMilestoneActivityVariant{

		/// <summary>
		/// The hash identifier of this activity variant. Examine the activity's definition in the Manifest database to determine what makes it a distinct variant. Usually it will be difficulty level or whether or not it is a guided game variant of the activity, but theoretically it could be distinguished in any arbitrary way.
		/// </summary>
		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		/// <summary>
		/// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
		/// </summary>
		[DataMember(Name="activityModeHash", EmitDefaultValue=false)]
		public uint ActivityModeHash { get; set; }

		/// <summary>
		/// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
		/// </summary>
		[DataMember(Name="activityModeType", EmitDefaultValue=false)]
		public long ActivityModeType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestoneActivityVariant);
        }

		public bool Equals(DestinyPublicMilestoneActivityVariant input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    ActivityModeHash == input.ActivityModeHash ||
                    (ActivityModeHash != null && ActivityModeHash.Equals(input.ActivityModeHash))
                ) &&
				(
                    ActivityModeType == input.ActivityModeType ||
                    (ActivityModeType != null && ActivityModeType.Equals(input.ActivityModeType))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
				hashCode = hashCode * 59 + this.ActivityModeHash.GetHashCode();
				hashCode = hashCode * 59 + this.ActivityModeType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

