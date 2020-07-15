using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
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
	}
}

