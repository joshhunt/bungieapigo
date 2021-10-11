package bungieapigo

type DestinyItemActionRequest struct {
	ItemId         int64                `json:"itemId,string"`
	CharacterId    int64                `json:"characterId,string"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
