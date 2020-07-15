using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPresentationNodeRecordChildEntry{

		[DataMember(Name="recordHash", EmitDefaultValue=false)]
		public uint RecordHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeRecordChildEntry);
        }

		public bool Equals(DestinyPresentationNodeRecordChildEntry input)
		{
			if (input == null) return false;

			return
				(
                    RecordHash == input.RecordHash ||
                    (RecordHash != null && RecordHash.Equals(input.RecordHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.RecordHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

