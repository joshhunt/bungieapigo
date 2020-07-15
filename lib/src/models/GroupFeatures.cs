using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupFeatures{

		[DataMember(Name="maximumMembers", EmitDefaultValue=false)]
		public long MaximumMembers { get; set; }

		/// <summary>
		/// Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.
		/// </summary>
		[DataMember(Name="maximumMembershipsOfGroupType", EmitDefaultValue=false)]
		public long MaximumMembershipsOfGroupType { get; set; }

		[DataMember(Name="capabilities", EmitDefaultValue=false)]
		public Capabilities Capabilities { get; set; }

		[DataMember(Name="membershipTypes", EmitDefaultValue=false)]
		public List<BungieMembershipType> MembershipTypes { get; set; }

		/// <summary>
		/// Minimum Member Level allowed to invite new members to group
		/// </summary>
		/// <summary>
		/// Always Allowed: Founder, Acting Founder
		/// </summary>
		/// <summary>
		/// True means admins have this power, false means they don't
		/// </summary>
		/// <summary>
		/// Default is false for clans, true for groups.
		/// </summary>
		[DataMember(Name="invitePermissionOverride", EmitDefaultValue=false)]
		public bool InvitePermissionOverride { get; set; }

		/// <summary>
		/// Minimum Member Level allowed to update group culture
		/// </summary>
		/// <summary>
		/// Always Allowed: Founder, Acting Founder
		/// </summary>
		/// <summary>
		/// True means admins have this power, false means they don't
		/// </summary>
		/// <summary>
		/// Default is false for clans, true for groups.
		/// </summary>
		[DataMember(Name="updateCulturePermissionOverride", EmitDefaultValue=false)]
		public bool UpdateCulturePermissionOverride { get; set; }

		/// <summary>
		/// Minimum Member Level allowed to host guided games
		/// </summary>
		/// <summary>
		/// Always Allowed: Founder, Acting Founder, Admin
		/// </summary>
		/// <summary>
		/// Allowed Overrides: None, Member, Beginner
		/// </summary>
		/// <summary>
		/// Default is Member for clans, None for groups, although this means nothing for groups.
		/// </summary>
		[DataMember(Name="hostGuidedGamePermissionOverride", EmitDefaultValue=false)]
		public HostGuidedGamesPermissionLevel HostGuidedGamePermissionOverride { get; set; }

		/// <summary>
		/// Minimum Member Level allowed to update banner
		/// </summary>
		/// <summary>
		/// Always Allowed: Founder, Acting Founder
		/// </summary>
		/// <summary>
		/// True means admins have this power, false means they don't
		/// </summary>
		/// <summary>
		/// Default is false for clans, true for groups.
		/// </summary>
		[DataMember(Name="updateBannerPermissionOverride", EmitDefaultValue=false)]
		public bool UpdateBannerPermissionOverride { get; set; }

		/// <summary>
		/// Level to join a member at when accepting an invite, application, or joining an open clan
		/// </summary>
		/// <summary>
		/// Default is Beginner.
		/// </summary>
		[DataMember(Name="joinLevel", EmitDefaultValue=false)]
		public RuntimeGroupMemberType JoinLevel { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupFeatures);
        }

		public bool Equals(GroupFeatures input)
		{
			if (input == null) return false;

			return
				(
                    MaximumMembers == input.MaximumMembers ||
                    (MaximumMembers != null && MaximumMembers.Equals(input.MaximumMembers))
                ) &&
				(
                    MaximumMembershipsOfGroupType == input.MaximumMembershipsOfGroupType ||
                    (MaximumMembershipsOfGroupType != null && MaximumMembershipsOfGroupType.Equals(input.MaximumMembershipsOfGroupType))
                ) &&
				(
                    Capabilities == input.Capabilities ||
                    (Capabilities != null && Capabilities.Equals(input.Capabilities))
                ) &&
				(
                    MembershipTypes == input.MembershipTypes ||
                    (MembershipTypes != null && MembershipTypes.Equals(input.MembershipTypes))
                ) &&
				(
                    InvitePermissionOverride == input.InvitePermissionOverride ||
                    (InvitePermissionOverride != null && InvitePermissionOverride.Equals(input.InvitePermissionOverride))
                ) &&
				(
                    UpdateCulturePermissionOverride == input.UpdateCulturePermissionOverride ||
                    (UpdateCulturePermissionOverride != null && UpdateCulturePermissionOverride.Equals(input.UpdateCulturePermissionOverride))
                ) &&
				(
                    HostGuidedGamePermissionOverride == input.HostGuidedGamePermissionOverride ||
                    (HostGuidedGamePermissionOverride != null && HostGuidedGamePermissionOverride.Equals(input.HostGuidedGamePermissionOverride))
                ) &&
				(
                    UpdateBannerPermissionOverride == input.UpdateBannerPermissionOverride ||
                    (UpdateBannerPermissionOverride != null && UpdateBannerPermissionOverride.Equals(input.UpdateBannerPermissionOverride))
                ) &&
				(
                    JoinLevel == input.JoinLevel ||
                    (JoinLevel != null && JoinLevel.Equals(input.JoinLevel))
                ) ;
		}
	}
}

