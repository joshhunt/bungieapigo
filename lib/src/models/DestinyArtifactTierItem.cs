using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyArtifactTierItem{

		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		[DataMember(Name="isActive", EmitDefaultValue=false)]
		public bool IsActive { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtifactTierItem);
        }

		public bool Equals(DestinyArtifactTierItem input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    IsActive == input.IsActive ||
                    (IsActive != null && IsActive.Equals(input.IsActive))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.IsActive.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

