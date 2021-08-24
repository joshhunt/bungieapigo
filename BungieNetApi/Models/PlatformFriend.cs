using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class PlatformFriend
    {
        [DataMember(Name = "platformDisplayName", EmitDefaultValue = false)]
        public string PlatformDisplayName { get; set; }

        [DataMember(Name = "friendPlatform", EmitDefaultValue = false)]
        public PlatformFriendType FriendPlatform { get; set; }

        [DataMember(Name = "destinyMembershipId", EmitDefaultValue = false)]
        public long DestinyMembershipId { get; set; }

        [DataMember(Name = "destinyMembershipType", EmitDefaultValue = false)]
        public long DestinyMembershipType { get; set; }

        [DataMember(Name = "bungieNetMembershipId", EmitDefaultValue = false)]
        public long BungieNetMembershipId { get; set; }

        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = false)]
        public long BungieGlobalDisplayNameCode { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformFriend);
        }

        public bool Equals(PlatformFriend input)
        {
            if (input == null) return false;

            return
                (
                    PlatformDisplayName == input.PlatformDisplayName ||
                    (PlatformDisplayName != null && PlatformDisplayName.Equals(input.PlatformDisplayName))
                ) &&
                (
                    FriendPlatform == input.FriendPlatform ||
                    (FriendPlatform != null && FriendPlatform.Equals(input.FriendPlatform))
                ) &&
                (
                    DestinyMembershipId == input.DestinyMembershipId ||
                    (DestinyMembershipId.Equals(input.DestinyMembershipId))
                ) &&
                (
                    DestinyMembershipType == input.DestinyMembershipType ||
                    (DestinyMembershipType.Equals(input.DestinyMembershipType))
                ) &&
                (
                    BungieNetMembershipId == input.BungieNetMembershipId ||
                    (BungieNetMembershipId.Equals(input.BungieNetMembershipId))
                ) &&
                (
                    BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (BungieGlobalDisplayName != null && BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) &&
                (
                    BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
                ) ;
        }
    }
}

