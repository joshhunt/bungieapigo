using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPresentationNodeCollectibleChildEntry{

		[DataMember(Name="collectibleHash", EmitDefaultValue=false)]
		public uint CollectibleHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeCollectibleChildEntry);
        }

		public bool Equals(DestinyPresentationNodeCollectibleChildEntry input)
		{
			if (input == null) return false;

			return
				(
                    CollectibleHash == input.CollectibleHash ||
                    (CollectibleHash != null && CollectibleHash.Equals(input.CollectibleHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.CollectibleHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

