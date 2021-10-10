package bungieapigo

type FireteamPlatformInviteResult int

const (
    FireteamPlatformInviteResultNone = 0
    FireteamPlatformInviteResultSuccess = 1
    FireteamPlatformInviteResultAlreadyInFireteam = 2
    FireteamPlatformInviteResultThrottled = 3
    FireteamPlatformInviteResultServiceError = 4
)