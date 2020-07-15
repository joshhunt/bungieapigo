using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupResponse{

		[DataMember(Name="detail", EmitDefaultValue=false)]
		public GroupV2 Detail { get; set; }

		[DataMember(Name="founder", EmitDefaultValue=false)]
		public GroupMember Founder { get; set; }

		[DataMember(Name="alliedIds", EmitDefaultValue=false)]
		public List<long> AlliedIds { get; set; }

		[DataMember(Name="parentGroup", EmitDefaultValue=false)]
		public GroupV2 ParentGroup { get; set; }

		[DataMember(Name="allianceStatus", EmitDefaultValue=false)]
		public GroupAllianceStatus AllianceStatus { get; set; }

		[DataMember(Name="groupJoinInviteCount", EmitDefaultValue=false)]
		public long GroupJoinInviteCount { get; set; }

		/// <summary>
		/// A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.
		/// </summary>
		[DataMember(Name="currentUserMembershipsInactiveForDestiny", EmitDefaultValue=false)]
		public bool CurrentUserMembershipsInactiveForDestiny { get; set; }

		/// <summary>
		/// This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.
		/// </summary>
		[DataMember(Name="currentUserMemberMap", EmitDefaultValue=false)]
		public Map<String, GroupMember> CurrentUserMemberMap { get; set; }

		/// <summary>
		/// This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.
		/// </summary>
		[DataMember(Name="currentUserPotentialMemberMap", EmitDefaultValue=false)]
		public Map<String, GroupPotentialMember> CurrentUserPotentialMemberMap { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupResponse);
        }

		public bool Equals(GroupResponse input)
		{
			if (input == null) return false;

			return
				(
                    Detail == input.Detail ||
                    (Detail != null && Detail.Equals(input.Detail))
                ) &&
				(
                    Founder == input.Founder ||
                    (Founder != null && Founder.Equals(input.Founder))
                ) &&
				(
                    AlliedIds == input.AlliedIds ||
                    (AlliedIds != null && AlliedIds.Equals(input.AlliedIds))
                ) &&
				(
                    ParentGroup == input.ParentGroup ||
                    (ParentGroup != null && ParentGroup.Equals(input.ParentGroup))
                ) &&
				(
                    AllianceStatus == input.AllianceStatus ||
                    (AllianceStatus != null && AllianceStatus.Equals(input.AllianceStatus))
                ) &&
				(
                    GroupJoinInviteCount == input.GroupJoinInviteCount ||
                    (GroupJoinInviteCount != null && GroupJoinInviteCount.Equals(input.GroupJoinInviteCount))
                ) &&
				(
                    CurrentUserMembershipsInactiveForDestiny == input.CurrentUserMembershipsInactiveForDestiny ||
                    (CurrentUserMembershipsInactiveForDestiny != null && CurrentUserMembershipsInactiveForDestiny.Equals(input.CurrentUserMembershipsInactiveForDestiny))
                ) &&
				(
                    CurrentUserMemberMap == input.CurrentUserMemberMap ||
                    (CurrentUserMemberMap != null && CurrentUserMemberMap.Equals(input.CurrentUserMemberMap))
                ) &&
				(
                    CurrentUserPotentialMemberMap == input.CurrentUserPotentialMemberMap ||
                    (CurrentUserPotentialMemberMap != null && CurrentUserPotentialMemberMap.Equals(input.CurrentUserPotentialMemberMap))
                ) ;
		}
	}
}

