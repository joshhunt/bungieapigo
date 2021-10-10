package bungieAPI

// There's a lot of places where we need to know scope on more than just a profile or character level. For everything else, there's this more generic sense of scope.
type DestinyScope int

const (
	DestinyScopeProfile   = 0
	DestinyScopeCharacter = 1
)
