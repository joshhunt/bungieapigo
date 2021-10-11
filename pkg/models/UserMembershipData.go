package bungieapigo

type UserMembershipData struct {

	// this allows you to see destiny memberships that are visible and linked to this account
	// (regardless of whether or not they have characters on the world server)
	DestinyMemberships []GroupUserInfoCard `json:"destinyMemberships"`

	// If this property is populated, it will have the membership ID of the account considered to be
	// "primary" in this user's cross save relationship.
	//  If null, this user has no cross save relationship, nor primary account.
	PrimaryMembershipId int64 `json:"primaryMembershipId"`

	BungieNetUser GeneralUser `json:"bungieNetUser"`
}
