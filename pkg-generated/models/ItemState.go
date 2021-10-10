package bungieAPI

// A flags enumeration/bitmask where each bit represents a different possible state that the
// item can be in that may effect how the item is displayed to the user and what actions can be
// performed against it.
type ItemState int

const (
	ItemStateNone = 0

	// If this bit is set, the item has been "locked" by the user and cannot be deleted. You may want to
	// represent this visually with a "lock" icon.
	ItemStateLocked = 1

	// If this bit is set, the item is a quest that's being tracked by the user. You may want a visual
	// indicator to show that this is a tracked quest.
	ItemStateTracked = 2

	// If this bit is set, the item has a Masterwork plug inserted. This usually coincides with having a
	// special "glowing" effect applied to the item's icon.
	ItemStateMasterwork = 4
)
