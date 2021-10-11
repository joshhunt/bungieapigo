package bungieapigo

// The types of membership the Accounts system supports. This is the external facing enum used in
// place of the internal-only Bungie.SharedDefinitions.MembershipType.
type BungieMembershipType int

const (
	BungieMembershipTypeNone          = 0
	BungieMembershipTypeTigerXbox     = 1
	BungieMembershipTypeTigerPsn      = 2
	BungieMembershipTypeTigerSteam    = 3
	BungieMembershipTypeTigerBlizzard = 4
	BungieMembershipTypeTigerStadia   = 5
	BungieMembershipTypeTigerDemon    = 10
	BungieMembershipTypeBungieNext    = 254

	// "All" is only valid for searching capabilities: you need to pass the actual matching
	// BungieMembershipType for any query where you pass a known membershipId.
	BungieMembershipTypeAll = -1
)
