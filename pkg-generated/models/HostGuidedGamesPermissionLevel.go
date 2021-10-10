package bungieAPI

// Used for setting the guided game permission level override (admins and founders can always
// host guided games).
type HostGuidedGamesPermissionLevel int

const (
	HostGuidedGamesPermissionLevelNone     = 0
	HostGuidedGamesPermissionLevelBeginner = 1
	HostGuidedGamesPermissionLevelMember   = 2
)
