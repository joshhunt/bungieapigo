package bungieAPI

type FriendRelationshipState int

const (
	FriendRelationshipStateUnknown         = 0
	FriendRelationshipStateFriend          = 1
	FriendRelationshipStateIncomingRequest = 2
	FriendRelationshipStateOutgoingRequest = 3
)
