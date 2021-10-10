package bungieAPI

type PagedQuery struct {
	ItemsPerPage             int    `json:"itemsPerPage"`
	CurrentPage              int    `json:"currentPage"`
	RequestContinuationToken string `json:"requestContinuationToken"`
}
