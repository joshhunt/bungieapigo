package bungieapigo

// Activity Modes are grouped into a few possible broad categories.
type DestinyActivityModeCategory int

const (

    // Activities that are neither PVP nor PVE, such as social activities.
    DestinyActivityModeCategoryNone = 0


    // PvE activities, where you shoot aliens in the face.
    DestinyActivityModeCategoryPvE = 1


    // PvP activities, where you shoot your "friends".
    DestinyActivityModeCategoryPvP = 2


    // PVE competitive activities, where you shoot whoever you want whenever you want. Or run around
    // collecting small glowing triangles.
    DestinyActivityModeCategoryPvECompetitive = 3

)