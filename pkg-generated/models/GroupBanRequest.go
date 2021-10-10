package bungieAPI

type GroupBanRequest struct {
	Comment string       `json:"comment"`
	Length  IgnoreLength `json:"length"`
}
