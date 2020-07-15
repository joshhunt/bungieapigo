using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemSetActionRequest{

		[DataMember(Name="itemIds", EmitDefaultValue=false)]
		public List<long> ItemIds { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSetActionRequest);
        }

		public bool Equals(DestinyItemSetActionRequest input)
		{
			if (input == null) return false;

			return
				(
                    ItemIds == input.ItemIds ||
                    (ItemIds != null && ItemIds.Equals(input.ItemIds))
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
	}
}

