package bungieapigo

type UserSearchResponseDetail struct {
	BungieGlobalDisplayName     string         `json:"bungieGlobalDisplayName"`
	BungieGlobalDisplayNameCode int            `json:"bungieGlobalDisplayNameCode"`
	BungieNetMembershipId       int64          `json:"bungieNetMembershipId"`
	DestinyMemberships          []UserInfoCard `json:"destinyMemberships"`
}
