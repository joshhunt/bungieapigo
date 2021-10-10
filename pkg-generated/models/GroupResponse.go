package bungieAPI

type GroupResponse struct {
	Detail               GroupV2             `json:"detail"`
	Founder              GroupMember         `json:"founder"`
	AlliedIds            []int64             `json:"alliedIds"`
	ParentGroup          GroupV2             `json:"parentGroup"`
	AllianceStatus       GroupAllianceStatus `json:"allianceStatus"`
	GroupJoinInviteCount int                 `json:"groupJoinInviteCount"`

	// A convenience property that indicates if every membership you (the current user) have that is a
	// part of this group are part of an account that is considered inactive - for example, overridden
	// accounts in Cross Save.
	CurrentUserMembershipsInactiveForDestiny bool `json:"currentUserMembershipsInactiveForDestiny"`

	// This property will be populated if the authenticated user is a member of the group. Note that
	// because of account linking, a user can sometimes be part of a clan more than once. As such, this
	// returns the highest member type available.
	CurrentUserMemberMap map[BungieMembershipType]GroupMember `json:"currentUserMemberMap"`

	// This property will be populated if the authenticated user is an applicant or has an outstanding
	// invitation to join. Note that because of account linking, a user can sometimes be part of a clan
	// more than once.
	CurrentUserPotentialMemberMap map[BungieMembershipType]GroupPotentialMember `json:"currentUserPotentialMemberMap"`
}
