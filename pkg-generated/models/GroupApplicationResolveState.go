package bungieAPI

type GroupApplicationResolveState int

const (
	GroupApplicationResolveStateUnresolved = 0
	GroupApplicationResolveStateAccepted   = 1
	GroupApplicationResolveStateDenied     = 2
	GroupApplicationResolveStateRescinded  = 3
)
