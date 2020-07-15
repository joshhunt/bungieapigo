using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyItemStateRequest
    {
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public bool State { get; set; }

        [DataMember(Name = "itemId", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemStateRequest);
        }

        public bool Equals(DestinyItemStateRequest input)
        {
            if (input == null) return false;

            return
                (
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) &&
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
    }
}

