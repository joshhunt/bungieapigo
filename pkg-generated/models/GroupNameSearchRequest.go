package bungieAPI

type GroupNameSearchRequest struct {
	GroupName string    `json:"groupName"`
	GroupType GroupType `json:"groupType"`
}
