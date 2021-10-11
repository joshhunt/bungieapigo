package bungieapigo

// There are many Progressions in Destiny (think Character Level, or Reputation). These are the
// various "Scopes" of Progressions, which affect many things: * Where/if they are stored * How
// they are calculated * Where they can be used in other game logic
type DestinyProgressionScope int

const (
	DestinyProgressionScopeAccount               = 0
	DestinyProgressionScopeCharacter             = 1
	DestinyProgressionScopeClan                  = 2
	DestinyProgressionScopeItem                  = 3
	DestinyProgressionScopeImplicitFromEquipment = 4
	DestinyProgressionScopeMapped                = 5
	DestinyProgressionScopeMappedAggregate       = 6
	DestinyProgressionScopeMappedStat            = 7
	DestinyProgressionScopeMappedUnlockValue     = 8
)
