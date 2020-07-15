using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyGearArtArrangementReference{

		[DataMember(Name="classHash", EmitDefaultValue=false)]
		public uint ClassHash { get; set; }

		[DataMember(Name="artArrangementHash", EmitDefaultValue=false)]
		public uint ArtArrangementHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyGearArtArrangementReference);
        }

		public bool Equals(DestinyGearArtArrangementReference input)
		{
			if (input == null) return false;

			return
				(
                    ClassHash == input.ClassHash ||
                    (ClassHash != null && ClassHash.Equals(input.ClassHash))
                ) &&
				(
                    ArtArrangementHash == input.ArtArrangementHash ||
                    (ArtArrangementHash != null && ArtArrangementHash.Equals(input.ArtArrangementHash))
                ) ;
		}
	}
}

