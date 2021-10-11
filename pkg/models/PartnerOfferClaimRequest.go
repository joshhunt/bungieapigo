package bungieapigo

type PartnerOfferClaimRequest struct {
	PartnerOfferId        string `json:"PartnerOfferId"`
	BungieNetMembershipId int64  `json:"BungieNetMembershipId,string"`
	TransactionId         string `json:"TransactionId"`
}
