package bungieapigo

import "time"

type DestinyProfileUserInfoCard struct {
	DateLastPlayed time.Time `json:"dateLastPlayed"`

	// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will
	// still return the profile for display purposes where users need to know the info: it is up to any
	// given area of the app/site to determine if this profile should still be shown.
	IsOverridden bool `json:"isOverridden"`

	// If true, this account is hooked up as the "Primary" cross save account for one or more platforms.
	IsCrossSavePrimary bool `json:"isCrossSavePrimary"`

	// This is the silver available on this Profile across any platforms on which they have purchased
	// silver.
	//  This is only available if you are requesting yourself.
	PlatformSilver DestinyPlatformSilverComponent `json:"platformSilver"`

	// If this profile is not in a cross save pairing, this will return the game versions that we believe
	// this profile has access to.
	//  For the time being, we will not return this information for any membership that is in a cross save
	// pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to
	// get that information for the profile's original Platform, and thus gameVersions would be too
	// inconsistent (based on the last platform they happened to play on) for the info to be useful.
	//  If we ever can get this data, this field will be deprecated and replaced with data on the
	// DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we
	// can't get that, we have this as a stop-gap measure for getting the data in the only situation that
	// we currently need it.
	UnpairedGameVersions int `json:"unpairedGameVersions"`

	// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
	SupplementalDisplayName string `json:"supplementalDisplayName"`

	// URL the Icon if available.
	IconPath string `json:"iconPath"`

	// If there is a cross save override in effect, this value will tell you the type that is overridding
	// this one.
	CrossSaveOverride BungieMembershipType `json:"crossSaveOverride"`

	// The list of Membership Types indicating the platforms on which this Membership can be used.
	//  Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is
	// overridding, and its original membership type Cross Save Overridden = Empty list
	ApplicableMembershipTypes []BungieMembershipType `json:"applicableMembershipTypes"`

	// If True, this is a public user membership.
	IsPublic bool `json:"isPublic"`

	// Type of the membership. Not necessarily the native type.
	MembershipType BungieMembershipType `json:"membershipType"`

	// Membership ID as they user is known in the Accounts service
	MembershipId int64 `json:"membershipId"`

	// Display Name the player has chosen for themselves. The display name is optional when the data
	// type is used as input to a platform API.
	DisplayName string `json:"displayName"`

	// The bungie global display name, if set.
	BungieGlobalDisplayName string `json:"bungieGlobalDisplayName"`

	// The bungie global display name code, if set.
	BungieGlobalDisplayNameCode int `json:"bungieGlobalDisplayNameCode"`
}
