using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class UserSearchResponseDetail
    {
        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = false)]
        public long BungieGlobalDisplayNameCode { get; set; }

        [DataMember(Name = "bungieNetMembershipId", EmitDefaultValue = false)]
        public long BungieNetMembershipId { get; set; }

        [DataMember(Name = "destinyMemberships", EmitDefaultValue = false)]
        public List<UserInfoCard> DestinyMemberships { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as UserSearchResponseDetail);
        }

        public bool Equals(UserSearchResponseDetail input)
        {
            if (input == null) return false;

            return
                (
                    BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (BungieGlobalDisplayName != null && BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) &&
                (
                    BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
                ) &&
                (
                    BungieNetMembershipId == input.BungieNetMembershipId ||
                    (BungieNetMembershipId.Equals(input.BungieNetMembershipId))
                ) &&
                (
                    DestinyMemberships == input.DestinyMemberships ||
                    (DestinyMemberships != null && DestinyMemberships.SequenceEqual(input.DestinyMemberships))
                ) ;
        }
    }
}

