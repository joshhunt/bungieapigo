package bungieAPI

type DestinyCharacterActionRequest struct {
	CharacterId    int64                `json:"characterId"`
	MembershipType BungieMembershipType `json:"membershipType"`
}