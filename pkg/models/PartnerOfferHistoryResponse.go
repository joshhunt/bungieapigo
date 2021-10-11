package bungieapigo

import "time"

type PartnerOfferHistoryResponse struct {
	PartnerOfferKey      string    `json:"PartnerOfferKey"`
	MembershipId         int64     `json:"MembershipId"`
	MembershipType       int       `json:"MembershipType"`
	LocalizedName        string    `json:"LocalizedName"`
	LocalizedDescription string    `json:"LocalizedDescription"`
	IsConsumable         bool      `json:"IsConsumable"`
	QuantityApplied      int       `json:"QuantityApplied"`
	ApplyDate            time.Time `json:"ApplyDate"`
}
