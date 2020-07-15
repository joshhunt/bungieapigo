using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyCharacterActionRequest{

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterActionRequest);
        }

		public bool Equals(DestinyCharacterActionRequest input)
		{
			if (input == null) return false;

			return
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

