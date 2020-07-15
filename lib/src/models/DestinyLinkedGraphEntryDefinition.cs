using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyLinkedGraphEntryDefinition{

		[DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
		public uint ActivityGraphHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLinkedGraphEntryDefinition);
        }

		public bool Equals(DestinyLinkedGraphEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ActivityGraphHash == input.ActivityGraphHash ||
                    (ActivityGraphHash != null && ActivityGraphHash.Equals(input.ActivityGraphHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityGraphHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

