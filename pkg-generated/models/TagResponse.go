package bungieAPI

type TagResponse struct {
	TagText      string         `json:"tagText"`
	IgnoreStatus IgnoreResponse `json:"ignoreStatus"`
}
