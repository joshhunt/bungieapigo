package bungieapigo

type GroupApplicationListRequest struct {
	Memberships []UserMembership `json:"memberships"`
	Message     string           `json:"message"`
}
