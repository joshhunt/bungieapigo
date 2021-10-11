package bungieapigo

import "time"

type PartnerOfferSkuHistoryResponse struct {
	SkuIdentifier        string                        `json:"SkuIdentifier"`
	LocalizedName        string                        `json:"LocalizedName"`
	LocalizedDescription string                        `json:"LocalizedDescription"`
	ClaimDate            time.Time                     `json:"ClaimDate"`
	AllOffersApplied     bool                          `json:"AllOffersApplied"`
	TransactionId        string                        `json:"TransactionId"`
	SkuOffers            []PartnerOfferHistoryResponse `json:"SkuOffers"`
}
