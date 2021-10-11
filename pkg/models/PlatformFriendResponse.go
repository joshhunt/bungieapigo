package bungieapigo

type PlatformFriendResponse struct {
	ItemsPerPage    int              `json:"itemsPerPage"`
	CurrentPage     int              `json:"currentPage"`
	HasMore         bool             `json:"hasMore"`
	PlatformFriends []PlatformFriend `json:"platformFriends"`
}
