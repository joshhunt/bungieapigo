using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ClanBanner{

		[DataMember(Name="decalId", EmitDefaultValue=false)]
		public uint DecalId { get; set; }

		[DataMember(Name="decalColorId", EmitDefaultValue=false)]
		public uint DecalColorId { get; set; }

		[DataMember(Name="decalBackgroundColorId", EmitDefaultValue=false)]
		public uint DecalBackgroundColorId { get; set; }

		[DataMember(Name="gonfalonId", EmitDefaultValue=false)]
		public uint GonfalonId { get; set; }

		[DataMember(Name="gonfalonColorId", EmitDefaultValue=false)]
		public uint GonfalonColorId { get; set; }

		[DataMember(Name="gonfalonDetailId", EmitDefaultValue=false)]
		public uint GonfalonDetailId { get; set; }

		[DataMember(Name="gonfalonDetailColorId", EmitDefaultValue=false)]
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
                    (DecalId != null && DecalId.Equals(input.DecalId))
                ) &&
				(
                    DecalColorId == input.DecalColorId ||
                    (DecalColorId != null && DecalColorId.Equals(input.DecalColorId))
                ) &&
				(
                    DecalBackgroundColorId == input.DecalBackgroundColorId ||
                    (DecalBackgroundColorId != null && DecalBackgroundColorId.Equals(input.DecalBackgroundColorId))
                ) &&
				(
                    GonfalonId == input.GonfalonId ||
                    (GonfalonId != null && GonfalonId.Equals(input.GonfalonId))
                ) &&
				(
                    GonfalonColorId == input.GonfalonColorId ||
                    (GonfalonColorId != null && GonfalonColorId.Equals(input.GonfalonColorId))
                ) &&
				(
                    GonfalonDetailId == input.GonfalonDetailId ||
                    (GonfalonDetailId != null && GonfalonDetailId.Equals(input.GonfalonDetailId))
                ) &&
				(
                    GonfalonDetailColorId == input.GonfalonDetailColorId ||
                    (GonfalonDetailColorId != null && GonfalonDetailColorId.Equals(input.GonfalonDetailColorId))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DecalId.GetHashCode();
				hashCode = hashCode * 59 + this.DecalColorId.GetHashCode();
				hashCode = hashCode * 59 + this.DecalBackgroundColorId.GetHashCode();
				hashCode = hashCode * 59 + this.GonfalonId.GetHashCode();
				hashCode = hashCode * 59 + this.GonfalonColorId.GetHashCode();
				hashCode = hashCode * 59 + this.GonfalonDetailId.GetHashCode();
				hashCode = hashCode * 59 + this.GonfalonDetailColorId.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

