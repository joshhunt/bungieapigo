using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// When a Graph needs to show active Progressions, this defines those objectives as well as an identifier.
	[DataContract]
	public class DestinyActivityGraphDisplayProgressionDefinition{

		[DataMember(Name="id", EmitDefaultValue=false)]
		public uint Id { get; set; }

		[DataMember(Name="progressionHash", EmitDefaultValue=false)]
		public uint ProgressionHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphDisplayProgressionDefinition);
        }

		public bool Equals(DestinyActivityGraphDisplayProgressionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Id == input.Id ||
                    (Id != null && Id.Equals(input.Id))
                ) &&
				(
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Id.GetHashCode();
				hashCode = hashCode * 59 + this.ProgressionHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

