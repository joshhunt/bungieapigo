package bungieAPI

type PartnerOfferClaimRequest struct {
	PartnerOfferId        string `json:"PartnerOfferId"`
	BungieNetMembershipId int64  `json:"BungieNetMembershipId"`
	TransactionId         string `json:"TransactionId"`
}
