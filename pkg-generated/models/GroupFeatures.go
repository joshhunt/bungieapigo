package bungieapigo

type GroupFeatures struct {
    MaximumMembers int `json:"maximumMembers"`

    // Maximum number of groups of this type a typical membership may join. For example, a user may join
    // about 50 General groups with their Bungie.net account. They may join one clan per Destiny
    // membership.
    MaximumMembershipsOfGroupType int `json:"maximumMembershipsOfGroupType"`

    Capabilities Capabilities `json:"capabilities"`
    MembershipTypes []BungieMembershipType `json:"membershipTypes"`

    // Minimum Member Level allowed to invite new members to group
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    InvitePermissionOverride bool `json:"invitePermissionOverride"`


    // Minimum Member Level allowed to update group culture
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    UpdateCulturePermissionOverride bool `json:"updateCulturePermissionOverride"`


    // Minimum Member Level allowed to host guided games
    // Always Allowed: Founder, Acting Founder, Admin
    // Allowed Overrides: None, Member, Beginner
    // Default is Member for clans, None for groups, although this means nothing for groups.
    HostGuidedGamePermissionOverride HostGuidedGamesPermissionLevel `json:"hostGuidedGamePermissionOverride"`


    // Minimum Member Level allowed to update banner
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    UpdateBannerPermissionOverride bool `json:"updateBannerPermissionOverride"`


    // Level to join a member at when accepting an invite, application, or joining an open clan
    // Default is Beginner.
    JoinLevel RuntimeGroupMemberType `json:"joinLevel"`

}

