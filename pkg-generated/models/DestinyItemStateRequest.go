package bungieapigo

type DestinyItemStateRequest struct {
    State bool `json:"state"`
    ItemId int64 `json:"itemId"`
    CharacterId int64 `json:"characterId"`
    MembershipType BungieMembershipType `json:"membershipType"`
}

