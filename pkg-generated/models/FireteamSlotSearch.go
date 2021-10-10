package bungieAPI

type FireteamSlotSearch int

const (
	FireteamSlotSearchNoSlotRestriction       = 0
	FireteamSlotSearchHasOpenPlayerSlots      = 1
	FireteamSlotSearchHasOpenPlayerOrAltSlots = 2
)
