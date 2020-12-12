using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class HardLinkedUserMembership
    {
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }

        [DataMember(Name = "membershipId", EmitDefaultValue = false)]
        public long MembershipId { get; set; }

        [DataMember(Name = "CrossSaveOverriddenType", EmitDefaultValue = false)]
        public BungieMembershipType CrossSaveOverriddenType { get; set; }

        [DataMember(Name = "CrossSaveOverriddenMembershipId", EmitDefaultValue = false)]
        public long CrossSaveOverriddenMembershipId { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as HardLinkedUserMembership);
        }

        public bool Equals(HardLinkedUserMembership input)
        {
            if (input == null) return false;

            return
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) &&
                (
                    MembershipId == input.MembershipId ||
                    (MembershipId.Equals(input.MembershipId))
                ) &&
                (
                    CrossSaveOverriddenType == input.CrossSaveOverriddenType ||
                    (CrossSaveOverriddenType != null && CrossSaveOverriddenType.Equals(input.CrossSaveOverriddenType))
                ) &&
                (
                    CrossSaveOverriddenMembershipId == input.CrossSaveOverriddenMembershipId ||
                    (CrossSaveOverriddenMembershipId.Equals(input.CrossSaveOverriddenMembershipId))
                ) ;
        }
    }
}

