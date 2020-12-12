using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class ClanBanner
    {
        [DataMember(Name = "decalId", EmitDefaultValue = false)]
        public uint DecalId { get; set; }

        [DataMember(Name = "decalColorId", EmitDefaultValue = false)]
        public uint DecalColorId { get; set; }

        [DataMember(Name = "decalBackgroundColorId", EmitDefaultValue = false)]
        public uint DecalBackgroundColorId { get; set; }

        [DataMember(Name = "gonfalonId", EmitDefaultValue = false)]
        public uint GonfalonId { get; set; }

        [DataMember(Name = "gonfalonColorId", EmitDefaultValue = false)]
        public uint GonfalonColorId { get; set; }

        [DataMember(Name = "gonfalonDetailId", EmitDefaultValue = false)]
        public uint GonfalonDetailId { get; set; }

        [DataMember(Name = "gonfalonDetailColorId", EmitDefaultValue = false)]
        public uint GonfalonDetailColorId { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as ClanBanner);
        }

        public bool Equals(ClanBanner input)
        {
            if (input == null) return false;

            return
                (
                    DecalId == input.DecalId ||
                    (DecalId.Equals(input.DecalId))
                ) &&
                (
                    DecalColorId == input.DecalColorId ||
                    (DecalColorId.Equals(input.DecalColorId))
                ) &&
                (
                    DecalBackgroundColorId == input.DecalBackgroundColorId ||
                    (DecalBackgroundColorId.Equals(input.DecalBackgroundColorId))
                ) &&
                (
                    GonfalonId == input.GonfalonId ||
                    (GonfalonId.Equals(input.GonfalonId))
                ) &&
                (
                    GonfalonColorId == input.GonfalonColorId ||
                    (GonfalonColorId.Equals(input.GonfalonColorId))
                ) &&
                (
                    GonfalonDetailId == input.GonfalonDetailId ||
                    (GonfalonDetailId.Equals(input.GonfalonDetailId))
                ) &&
                (
                    GonfalonDetailColorId == input.GonfalonDetailColorId ||
                    (GonfalonDetailColorId.Equals(input.GonfalonDetailColorId))
                ) ;
        }
    }
}

