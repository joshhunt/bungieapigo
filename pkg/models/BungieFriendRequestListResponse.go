package bungieapigo

type BungieFriendRequestListResponse struct {
	IncomingRequests []BungieFriend `json:"incomingRequests"`
	OutgoingRequests []BungieFriend `json:"outgoingRequests"`
}
