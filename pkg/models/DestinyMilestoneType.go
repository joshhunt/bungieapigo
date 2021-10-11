package bungieapigo

// The type of milestone. Milestones can be Tutorials, one-time/triggered/non-repeating but
// not necessarily tutorials, or Repeating Milestones.
type DestinyMilestoneType int

const (
	DestinyMilestoneTypeUnknown = 0

	// One-time milestones that are specifically oriented toward teaching players about new
	// mechanics and gameplay modes.
	DestinyMilestoneTypeTutorial = 1

	// Milestones that, once completed a single time, can never be repeated.
	DestinyMilestoneTypeOneTime = 2

	// Milestones that repeat/reset on a weekly basis. They need not all reset on the same day or time,
	// but do need to reset weekly to qualify for this type.
	DestinyMilestoneTypeWeekly = 3

	// Milestones that repeat or reset on a daily basis.
	DestinyMilestoneTypeDaily = 4

	// Special indicates that the event is not on a daily/weekly cadence, but does occur more than
	// once. For instance, Iron Banner in Destiny 1 or the Dawning were examples of what could be termed
	// "Special" events.
	DestinyMilestoneTypeSpecial = 5
)
