package bungieapigo

type PlatformFriend struct {
	PlatformDisplayName         string             `json:"platformDisplayName"`
	FriendPlatform              PlatformFriendType `json:"friendPlatform"`
	DestinyMembershipId         int64              `json:"destinyMembershipId"`
	DestinyMembershipType       int                `json:"destinyMembershipType"`
	BungieNetMembershipId       int64              `json:"bungieNetMembershipId"`
	BungieGlobalDisplayName     string             `json:"bungieGlobalDisplayName"`
	BungieGlobalDisplayNameCode int                `json:"bungieGlobalDisplayNameCode"`
}
