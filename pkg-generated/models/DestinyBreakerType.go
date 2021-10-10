package bungieAPI

// A plug can optionally have a "Breaker Type": a special ability that can affect units in unique ways. Activating this plug can grant one of these types.
type DestinyBreakerType int

const (
	DestinyBreakerTypeNone           = 0
	DestinyBreakerTypeShieldPiercing = 1
	DestinyBreakerTypeDisruption     = 2
	DestinyBreakerTypeStagger        = 3
)
