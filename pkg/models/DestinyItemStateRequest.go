package bungieapigo

type DestinyItemStateRequest struct {
	State          bool                 `json:"state"`
	ItemId         int64                `json:"itemId,string"`
	CharacterId    int64                `json:"characterId,string"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
