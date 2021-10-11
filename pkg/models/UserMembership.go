package bungieapigo

// Very basic info about a user as returned by the Account server.
type UserMembership struct {

	// Type of the membership. Not necessarily the native type.
	MembershipType BungieMembershipType `json:"membershipType"`

	// Membership ID as they user is known in the Accounts service
	MembershipId int64 `json:"membershipId,string"`

	// Display Name the player has chosen for themselves. The display name is optional when the data
	// type is used as input to a platform API.
	DisplayName string `json:"displayName"`

	// The bungie global display name, if set.
	BungieGlobalDisplayName string `json:"bungieGlobalDisplayName"`

	// The bungie global display name code, if set.
	BungieGlobalDisplayNameCode int `json:"bungieGlobalDisplayNameCode"`
}
