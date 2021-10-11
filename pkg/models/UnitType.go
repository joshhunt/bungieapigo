package bungieapigo

type UnitType int

const (
	UnitTypeNone = 0

	// Indicates the statistic is a simple count of something.
	UnitTypeCount = 1

	// Indicates the statistic is a per game average.
	UnitTypePerGame = 2

	// Indicates the number of seconds
	UnitTypeSeconds = 3

	// Indicates the number of points earned
	UnitTypePoints = 4

	// Values represents a team ID
	UnitTypeTeam = 5

	// Values represents a distance (units to-be-determined)
	UnitTypeDistance = 6

	// Ratio represented as a whole value from 0 to 100.
	UnitTypePercent = 7

	// Ratio of something, shown with decimal places
	UnitTypeRatio = 8

	// True or false
	UnitTypeBoolean = 9

	// The stat is actually a weapon type.
	UnitTypeWeaponType = 10

	// Indicates victory, defeat, or something in between.
	UnitTypeStanding = 11

	// Number of milliseconds some event spanned. For example, race time, or lap time.
	UnitTypeMilliseconds = 12

	// The value is a enumeration of the Completion Reason type.
	UnitTypeCompletionReason = 13
)
