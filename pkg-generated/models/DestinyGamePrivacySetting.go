package bungieapigo

// A player can choose to restrict requests to join their Fireteam to specific states. These are
// the possible states a user can choose.
type DestinyGamePrivacySetting int

const (
    DestinyGamePrivacySettingOpen = 0
    DestinyGamePrivacySettingClanAndFriendsOnly = 1
    DestinyGamePrivacySettingFriendsOnly = 2
    DestinyGamePrivacySettingInvitationOnly = 3
    DestinyGamePrivacySettingClosed = 4
)