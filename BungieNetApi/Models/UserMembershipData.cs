using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class UserMembershipData
    {
        /// <summary>
        /// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
        /// </summary>
        [DataMember(Name = "destinyMemberships", EmitDefaultValue = false)]
        public List<GroupUserInfoCard> DestinyMemberships { get; set; }

        /// <summary>
        /// If this property is populated, it will have the membership ID of the account considered to be "primary" in this user's cross save relationship.
        /// </summary>
        /// <summary>
        ///  If null, this user has no cross save relationship, nor primary account.
        /// </summary>
        [DataMember(Name = "primaryMembershipId", EmitDefaultValue = false)]
        public long PrimaryMembershipId { get; set; }

        [DataMember(Name = "bungieNetUser", EmitDefaultValue = false)]
        public GeneralUser BungieNetUser { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as UserMembershipData);
        }

        public bool Equals(UserMembershipData input)
        {
            if (input == null) return false;

            return
                (
                    DestinyMemberships == input.DestinyMemberships ||
                    (DestinyMemberships != null && DestinyMemberships.Equals(input.DestinyMemberships))
                ) &&
                (
                    PrimaryMembershipId == input.PrimaryMembershipId ||
                    (PrimaryMembershipId != null && PrimaryMembershipId.Equals(input.PrimaryMembershipId))
                ) &&
                (
                    BungieNetUser == input.BungieNetUser ||
                    (BungieNetUser != null && BungieNetUser.Equals(input.BungieNetUser))
                ) ;
        }
    }
}

