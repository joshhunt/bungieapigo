using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyArtifactTierItemDefinition{

		/// <summary>
		/// The identifier of the Plug Item unlocked by activating this item in the Artifact.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtifactTierItemDefinition);
        }

		public bool Equals(DestinyArtifactTierItemDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

