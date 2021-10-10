package bungieAPI

// Indicates how a perk should be shown, or if it should be, in the game UI. Maybe useful for those of you trying to filter out internal-use-only perks (or for those of you trying to figure out what they do!)
type ItemPerkVisibility int

const (
	ItemPerkVisibilityVisible  = 0
	ItemPerkVisibilityDisabled = 1
	ItemPerkVisibilityHidden   = 2
)
