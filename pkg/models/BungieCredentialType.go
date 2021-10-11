package bungieapigo

// The types of credentials the Accounts system supports. This is the external facing enum used in
// place of the internal-only Bungie.SharedDefinitions.CredentialType.
type BungieCredentialType int

const (
	BungieCredentialTypeNone        = 0
	BungieCredentialTypeXuid        = 1
	BungieCredentialTypePsnid       = 2
	BungieCredentialTypeWlid        = 3
	BungieCredentialTypeFake        = 4
	BungieCredentialTypeFacebook    = 5
	BungieCredentialTypeGoogle      = 8
	BungieCredentialTypeWindows     = 9
	BungieCredentialTypeDemonId     = 10
	BungieCredentialTypeSteamId     = 12
	BungieCredentialTypeBattleNetId = 14
	BungieCredentialTypeStadiaId    = 16
	BungieCredentialTypeTwitchId    = 18
)
