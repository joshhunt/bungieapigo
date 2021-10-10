package bungieapigo

type GroupOptionsEditAction struct {

    // Minimum Member Level allowed to invite new members to group
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    InvitePermissionOverride bool `json:"InvitePermissionOverride"`


    // Minimum Member Level allowed to update group culture
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    UpdateCulturePermissionOverride bool `json:"UpdateCulturePermissionOverride"`


    // Minimum Member Level allowed to host guided games
    // Always Allowed: Founder, Acting Founder, Admin
    // Allowed Overrides: None, Member, Beginner
    // Default is Member for clans, None for groups, although this means nothing for groups.
    HostGuidedGamePermissionOverride int `json:"HostGuidedGamePermissionOverride"`


    // Minimum Member Level allowed to update banner
    // Always Allowed: Founder, Acting Founder
    // True means admins have this power, false means they don't
    // Default is false for clans, true for groups.
    UpdateBannerPermissionOverride bool `json:"UpdateBannerPermissionOverride"`


    // Level to join a member at when accepting an invite, application, or joining an open clan
    // Default is Beginner.
    JoinLevel int `json:"JoinLevel"`

}

