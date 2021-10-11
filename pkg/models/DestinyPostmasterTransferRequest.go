package bungieapigo

type DestinyPostmasterTransferRequest struct {
	ItemReferenceHash int                  `json:"itemReferenceHash"`
	StackSize         int                  `json:"stackSize"`
	ItemId            int64                `json:"itemId,string"`
	CharacterId       int64                `json:"characterId,string"`
	MembershipType    BungieMembershipType `json:"membershipType"`
}
