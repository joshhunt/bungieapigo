package bungieAPI

type IgnoreLength int

const (
	IgnoreLengthNone         = 0
	IgnoreLengthWeek         = 1
	IgnoreLengthTwoWeeks     = 2
	IgnoreLengthThreeWeeks   = 3
	IgnoreLengthMonth        = 4
	IgnoreLengthThreeMonths  = 5
	IgnoreLengthSixMonths    = 6
	IgnoreLengthYear         = 7
	IgnoreLengthForever      = 8
	IgnoreLengthThreeMinutes = 9
	IgnoreLengthHour         = 10
	IgnoreLengthThirtyDays   = 11
)
