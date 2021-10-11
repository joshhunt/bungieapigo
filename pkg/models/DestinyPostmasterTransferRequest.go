package bungieapigo

type DestinyPostmasterTransferRequest struct {
	ItemReferenceHash int                  `json:"itemReferenceHash"`
	StackSize         int                  `json:"stackSize"`
	ItemId            int64                `json:"itemId"`
	CharacterId       int64                `json:"characterId"`
	MembershipType    BungieMembershipType `json:"membershipType"`
}
