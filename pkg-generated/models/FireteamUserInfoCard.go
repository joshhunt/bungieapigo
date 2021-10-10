package bungieAPI

type FireteamUserInfoCard struct {
	FireteamDisplayName    string               `json:"FireteamDisplayName"`
	FireteamMembershipType BungieMembershipType `json:"FireteamMembershipType"`

	// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
	SupplementalDisplayName string `json:"supplementalDisplayName"`

	// URL the Icon if available.
	IconPath string `json:"iconPath"`

	// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
	CrossSaveOverride BungieMembershipType `json:"crossSaveOverride"`

	// The list of Membership Types indicating the platforms on which this Membership can be used.
	//  Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list
	ApplicableMembershipTypes []BungieMembershipType `json:"applicableMembershipTypes"`

	// If True, this is a public user membership.
	IsPublic bool `json:"isPublic"`

	// Type of the membership. Not necessarily the native type.
	MembershipType BungieMembershipType `json:"membershipType"`

	// Membership ID as they user is known in the Accounts service
	MembershipId int64 `json:"membershipId"`

	// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
	DisplayName string `json:"displayName"`

	// The bungie global display name, if set.
	BungieGlobalDisplayName string `json:"bungieGlobalDisplayName"`

	// The bungie global display name code, if set.
	BungieGlobalDisplayNameCode int `json:"bungieGlobalDisplayNameCode"`
}
