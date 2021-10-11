package bungieapigo

type UserSearchResponseDetail struct {
	BungieGlobalDisplayName     string         `json:"bungieGlobalDisplayName"`
	BungieGlobalDisplayNameCode int            `json:"bungieGlobalDisplayNameCode"`
	BungieNetMembershipId       int64          `json:"bungieNetMembershipId,string"`
	DestinyMemberships          []UserInfoCard `json:"destinyMemberships"`
}
