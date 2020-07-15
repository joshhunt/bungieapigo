using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class HardLinkedUserMembership{

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }

		[DataMember(Name="membershipId", EmitDefaultValue=false)]
		public long MembershipId { get; set; }

		[DataMember(Name="CrossSaveOverriddenType", EmitDefaultValue=false)]
		public BungieMembershipType CrossSaveOverriddenType { get; set; }

		[DataMember(Name="CrossSaveOverriddenMembershipId", EmitDefaultValue=false)]
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
                    (MembershipId != null && MembershipId.Equals(input.MembershipId))
                ) &&
				(
                    CrossSaveOverriddenType == input.CrossSaveOverriddenType ||
                    (CrossSaveOverriddenType != null && CrossSaveOverriddenType.Equals(input.CrossSaveOverriddenType))
                ) &&
				(
                    CrossSaveOverriddenMembershipId == input.CrossSaveOverriddenMembershipId ||
                    (CrossSaveOverriddenMembershipId != null && CrossSaveOverriddenMembershipId.Equals(input.CrossSaveOverriddenMembershipId))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
				hashCode = hashCode * 59 + this.CrossSaveOverriddenType.GetHashCode();
				hashCode = hashCode * 59 + this.CrossSaveOverriddenMembershipId.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

