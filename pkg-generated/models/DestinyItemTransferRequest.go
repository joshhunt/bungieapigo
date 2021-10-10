package bungieapigo

type DestinyItemTransferRequest struct {
    ItemReferenceHash int `json:"itemReferenceHash"`
    StackSize int `json:"stackSize"`
    TransferToVault bool `json:"transferToVault"`
    ItemId int64 `json:"itemId"`
    CharacterId int64 `json:"characterId"`
    MembershipType BungieMembershipType `json:"membershipType"`
}

