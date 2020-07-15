using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemActionRequest{

		[DataMember(Name="itemId", EmitDefaultValue=false)]
		public long ItemId { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemActionRequest);
        }

		public bool Equals(DestinyItemActionRequest input)
		{
			if (input == null) return false;

			return
				(
                    ItemId == input.ItemId ||
                    (ItemId != null && ItemId.Equals(input.ItemId))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemId.GetHashCode();
				hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

