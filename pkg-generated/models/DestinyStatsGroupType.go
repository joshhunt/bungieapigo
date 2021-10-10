package bungieapigo

// If the enum value is > 100, it is a "special" group that cannot be queried for directly (special
// cases apply to when they are returned, and are not relevant in general cases)
type DestinyStatsGroupType int

const (
    DestinyStatsGroupTypeNone = 0
    DestinyStatsGroupTypeGeneral = 1
    DestinyStatsGroupTypeWeapons = 2
    DestinyStatsGroupTypeMedals = 3

    // This is purely to serve as the dividing line between filterable and un-filterable groups.
    // Below this number is a group you can pass as a filter. Above it are groups used in very specific
    // circumstances and not relevant for filtering.
    DestinyStatsGroupTypeReservedGroups = 100


    // Only applicable while generating leaderboards.
    DestinyStatsGroupTypeLeaderboard = 101


    // These will *only* be consumed by GetAggregateStatsByActivity
    DestinyStatsGroupTypeActivity = 102


    // These are only consumed and returned by GetUniqueWeaponHistory
    DestinyStatsGroupTypeUniqueWeapon = 103

    DestinyStatsGroupTypeInternal = 104
)