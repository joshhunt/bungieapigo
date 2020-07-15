using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPresentationNodeChildEntry{

		[DataMember(Name="presentationNodeHash", EmitDefaultValue=false)]
		public uint PresentationNodeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeChildEntry);
        }

		public bool Equals(DestinyPresentationNodeChildEntry input)
		{
			if (input == null) return false;

			return
				(
                    PresentationNodeHash == input.PresentationNodeHash ||
                    (PresentationNodeHash != null && PresentationNodeHash.Equals(input.PresentationNodeHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.PresentationNodeHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

