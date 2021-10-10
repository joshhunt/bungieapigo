package bungieAPI

// Indicates the type of actions that can be performed
type SocketTypeActionType int

const (
	SocketTypeActionTypeInsertPlug         = 0
	SocketTypeActionTypeInfuseItem         = 1
	SocketTypeActionTypeReinitializeSocket = 2
)
