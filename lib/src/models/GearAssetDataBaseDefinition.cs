using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GearAssetDataBaseDefinition{

		[DataMember(Name="version", EmitDefaultValue=false)]
		public long Version { get; set; }

		[DataMember(Name="path", EmitDefaultValue=false)]
		public string Path { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GearAssetDataBaseDefinition);
        }

		public bool Equals(GearAssetDataBaseDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Version == input.Version ||
                    (Version != null && Version.Equals(input.Version))
                ) &&
				(
                    Path == input.Path ||
                    (Path != null && Path.Equals(input.Path))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Version.GetHashCode();
				hashCode = hashCode * 59 + this.Path.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

