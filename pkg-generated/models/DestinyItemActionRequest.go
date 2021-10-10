package bungieAPI

type DestinyItemActionRequest struct {
	ItemId         int64                `json:"itemId"`
	CharacterId    int64                `json:"characterId"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
