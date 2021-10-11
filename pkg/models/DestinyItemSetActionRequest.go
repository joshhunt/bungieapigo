package bungieapigo

type DestinyItemSetActionRequest struct {
	ItemIds        []int64              `json:"itemIds"`
	CharacterId    int64                `json:"characterId"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
