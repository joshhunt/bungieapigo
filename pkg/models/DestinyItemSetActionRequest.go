package bungieapigo

type DestinyItemSetActionRequest struct {
	ItemIds        []int64              `json:"itemIds"`
	CharacterId    int64                `json:"characterId,string"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
