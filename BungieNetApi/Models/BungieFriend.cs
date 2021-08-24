using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class BungieFriend
    {
        [DataMember(Name = "lastSeenAsMembershipId", EmitDefaultValue = false)]
        public long LastSeenAsMembershipId { get; set; }

        [DataMember(Name = "lastSeenAsBungieMembershipType", EmitDefaultValue = false)]
        public BungieMembershipType LastSeenAsBungieMembershipType { get; set; }

        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = false)]
        public long BungieGlobalDisplayNameCode { get; set; }

        [DataMember(Name = "onlineStatus", EmitDefaultValue = false)]
        public PresenceStatus OnlineStatus { get; set; }

        [DataMember(Name = "onlineTitle", EmitDefaultValue = false)]
        public PresenceOnlineStateFlags OnlineTitle { get; set; }

        [DataMember(Name = "relationship", EmitDefaultValue = false)]
        public FriendRelationshipState Relationship { get; set; }

        [DataMember(Name = "bungieNetUser", EmitDefaultValue = false)]
        public GeneralUser BungieNetUser { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as BungieFriend);
        }

        public bool Equals(BungieFriend input)
        {
            if (input == null) return false;

            return
                (
                    LastSeenAsMembershipId == input.LastSeenAsMembershipId ||
                    (LastSeenAsMembershipId.Equals(input.LastSeenAsMembershipId))
                ) &&
                (
                    LastSeenAsBungieMembershipType == input.LastSeenAsBungieMembershipType ||
                    (LastSeenAsBungieMembershipType != null && LastSeenAsBungieMembershipType.Equals(input.LastSeenAsBungieMembershipType))
                ) &&
                (
                    BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (BungieGlobalDisplayName != null && BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) &&
                (
                    BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
                ) &&
                (
                    OnlineStatus == input.OnlineStatus ||
                    (OnlineStatus != null && OnlineStatus.Equals(input.OnlineStatus))
                ) &&
                (
                    OnlineTitle == input.OnlineTitle ||
                    (OnlineTitle != null && OnlineTitle.Equals(input.OnlineTitle))
                ) &&
                (
                    Relationship == input.Relationship ||
                    (Relationship != null && Relationship.Equals(input.Relationship))
                ) &&
                (
                    BungieNetUser == input.BungieNetUser ||
                    (BungieNetUser != null && BungieNetUser.Equals(input.BungieNetUser))
                ) ;
        }
    }
}

