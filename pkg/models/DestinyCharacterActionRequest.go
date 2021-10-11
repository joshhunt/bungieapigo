package bungieapigo

type DestinyCharacterActionRequest struct {
	CharacterId    int64                `json:"characterId,string"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
