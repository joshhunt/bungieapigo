using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyMilestoneChallengeActivityGraphNodeEntry{

		[DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
		public uint ActivityGraphHash { get; set; }

		[DataMember(Name="activityGraphNodeHash", EmitDefaultValue=false)]
		public uint ActivityGraphNodeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeActivityGraphNodeEntry);
        }

		public bool Equals(DestinyMilestoneChallengeActivityGraphNodeEntry input)
		{
			if (input == null) return false;

			return
				(
                    ActivityGraphHash == input.ActivityGraphHash ||
                    (ActivityGraphHash != null && ActivityGraphHash.Equals(input.ActivityGraphHash))
                ) &&
				(
                    ActivityGraphNodeHash == input.ActivityGraphNodeHash ||
                    (ActivityGraphNodeHash != null && ActivityGraphNodeHash.Equals(input.ActivityGraphNodeHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityGraphHash.GetHashCode();
				hashCode = hashCode * 59 + this.ActivityGraphNodeHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

