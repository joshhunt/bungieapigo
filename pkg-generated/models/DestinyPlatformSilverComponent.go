package bungieAPI

type DestinyPlatformSilverComponent struct {

	// If a Profile is played on multiple platforms, this is the silver they have for each platform,
	// keyed by Membership Type.
	PlatformSilver map[BungieMembershipType]DestinyItemComponent `json:"platformSilver"`
}
