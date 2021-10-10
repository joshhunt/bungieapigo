package bungieAPI

type DestinySocketVisibility int

const (
	DestinySocketVisibilityVisible                  = 0
	DestinySocketVisibilityHidden                   = 1
	DestinySocketVisibilityHiddenWhenEmpty          = 2
	DestinySocketVisibilityHiddenIfNoPlugsAvailable = 3
)
