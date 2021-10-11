package bungieapigo

type GroupNameSearchRequest struct {
	GroupName string    `json:"groupName"`
	GroupType GroupType `json:"groupType"`
}
