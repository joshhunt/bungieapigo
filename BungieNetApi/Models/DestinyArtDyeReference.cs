using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyArtDyeReference
    {
        [DataMember(Name = "artDyeChannelHash", EmitDefaultValue = false)]
        public uint ArtDyeChannelHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtDyeReference);
        }

        public bool Equals(DestinyArtDyeReference input)
        {
            if (input == null) return false;

            return
                (
                    ArtDyeChannelHash == input.ArtDyeChannelHash ||
                    (ArtDyeChannelHash != null && ArtDyeChannelHash.Equals(input.ArtDyeChannelHash))
                ) ;
        }
    }
}

