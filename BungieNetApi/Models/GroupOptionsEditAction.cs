using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupOptionsEditAction
    {
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
        [DataMember(Name = "InvitePermissionOverride", EmitDefaultValue = false)]
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
        [DataMember(Name = "UpdateCulturePermissionOverride", EmitDefaultValue = false)]
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
        [DataMember(Name = "HostGuidedGamePermissionOverride", EmitDefaultValue = false)]
        public long HostGuidedGamePermissionOverride { get; set; }

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
        [DataMember(Name = "UpdateBannerPermissionOverride", EmitDefaultValue = false)]
        public bool UpdateBannerPermissionOverride { get; set; }

        /// <summary>
        /// Level to join a member at when accepting an invite, application, or joining an open clan
        /// </summary>
        /// <summary>
        /// Default is Beginner.
        /// </summary>
        [DataMember(Name = "JoinLevel", EmitDefaultValue = false)]
        public long JoinLevel { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupOptionsEditAction);
        }

        public bool Equals(GroupOptionsEditAction input)
        {
            if (input == null) return false;

            return
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
                    (HostGuidedGamePermissionOverride.Equals(input.HostGuidedGamePermissionOverride))
                ) &&
                (
                    UpdateBannerPermissionOverride == input.UpdateBannerPermissionOverride ||
                    (UpdateBannerPermissionOverride != null && UpdateBannerPermissionOverride.Equals(input.UpdateBannerPermissionOverride))
                ) &&
                (
                    JoinLevel == input.JoinLevel ||
                    (JoinLevel.Equals(input.JoinLevel))
                ) ;
        }
    }
}

