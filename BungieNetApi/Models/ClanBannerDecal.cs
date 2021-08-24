using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class ClanBannerDecal
    {
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        [DataMember(Name = "foregroundPath", EmitDefaultValue = false)]
        public string ForegroundPath { get; set; }

        [DataMember(Name = "backgroundPath", EmitDefaultValue = false)]
        public string BackgroundPath { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as ClanBannerDecal);
        }

        public bool Equals(ClanBannerDecal input)
        {
            if (input == null) return false;

            return
                (
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
                (
                    ForegroundPath == input.ForegroundPath ||
                    (ForegroundPath != null && ForegroundPath.Equals(input.ForegroundPath))
                ) &&
                (
                    BackgroundPath == input.BackgroundPath ||
                    (BackgroundPath != null && BackgroundPath.Equals(input.BackgroundPath))
                ) ;
        }
    }
}

