package bungieAPI

// For historical reasons, this list will have both D1 and D2-relevant Activity Modes in it.
// Please don't take this to mean that some D1-only feature is coming back!
type DestinyActivityModeType int

const (
	DestinyActivityModeTypeNone       = 0
	DestinyActivityModeTypeStory      = 2
	DestinyActivityModeTypeStrike     = 3
	DestinyActivityModeTypeRaid       = 4
	DestinyActivityModeTypeAllPvP     = 5
	DestinyActivityModeTypePatrol     = 6
	DestinyActivityModeTypeAllPvE     = 7
	DestinyActivityModeTypeReserved9  = 9
	DestinyActivityModeTypeControl    = 10
	DestinyActivityModeTypeReserved11 = 11

	// Clash -> Destiny's name for Team Deathmatch. 4v4 combat, the team with the highest kills at the
	// end of time wins.
	DestinyActivityModeTypeClash = 12

	DestinyActivityModeTypeReserved13              = 13
	DestinyActivityModeTypeCrimsonDoubles          = 15
	DestinyActivityModeTypeNightfall               = 16
	DestinyActivityModeTypeHeroicNightfall         = 17
	DestinyActivityModeTypeAllStrikes              = 18
	DestinyActivityModeTypeIronBanner              = 19
	DestinyActivityModeTypeReserved20              = 20
	DestinyActivityModeTypeReserved21              = 21
	DestinyActivityModeTypeReserved22              = 22
	DestinyActivityModeTypeReserved24              = 24
	DestinyActivityModeTypeAllMayhem               = 25
	DestinyActivityModeTypeReserved26              = 26
	DestinyActivityModeTypeReserved27              = 27
	DestinyActivityModeTypeReserved28              = 28
	DestinyActivityModeTypeReserved29              = 29
	DestinyActivityModeTypeReserved30              = 30
	DestinyActivityModeTypeSupremacy               = 31
	DestinyActivityModeTypePrivateMatchesAll       = 32
	DestinyActivityModeTypeSurvival                = 37
	DestinyActivityModeTypeCountdown               = 38
	DestinyActivityModeTypeTrialsOfTheNine         = 39
	DestinyActivityModeTypeSocial                  = 40
	DestinyActivityModeTypeTrialsCountdown         = 41
	DestinyActivityModeTypeTrialsSurvival          = 42
	DestinyActivityModeTypeIronBannerControl       = 43
	DestinyActivityModeTypeIronBannerClash         = 44
	DestinyActivityModeTypeIronBannerSupremacy     = 45
	DestinyActivityModeTypeScoredNightfall         = 46
	DestinyActivityModeTypeScoredHeroicNightfall   = 47
	DestinyActivityModeTypeRumble                  = 48
	DestinyActivityModeTypeAllDoubles              = 49
	DestinyActivityModeTypeDoubles                 = 50
	DestinyActivityModeTypePrivateMatchesClash     = 51
	DestinyActivityModeTypePrivateMatchesControl   = 52
	DestinyActivityModeTypePrivateMatchesSupremacy = 53
	DestinyActivityModeTypePrivateMatchesCountdown = 54
	DestinyActivityModeTypePrivateMatchesSurvival  = 55
	DestinyActivityModeTypePrivateMatchesMayhem    = 56
	DestinyActivityModeTypePrivateMatchesRumble    = 57
	DestinyActivityModeTypeHeroicAdventure         = 58
	DestinyActivityModeTypeShowdown                = 59
	DestinyActivityModeTypeLockdown                = 60
	DestinyActivityModeTypeScorched                = 61
	DestinyActivityModeTypeScorchedTeam            = 62
	DestinyActivityModeTypeGambit                  = 63
	DestinyActivityModeTypeAllPvECompetitive       = 64
	DestinyActivityModeTypeBreakthrough            = 65
	DestinyActivityModeTypeBlackArmoryRun          = 66
	DestinyActivityModeTypeSalvage                 = 67
	DestinyActivityModeTypeIronBannerSalvage       = 68
	DestinyActivityModeTypePvPCompetitive          = 69
	DestinyActivityModeTypePvPQuickplay            = 70
	DestinyActivityModeTypeClashQuickplay          = 71
	DestinyActivityModeTypeClashCompetitive        = 72
	DestinyActivityModeTypeControlQuickplay        = 73
	DestinyActivityModeTypeControlCompetitive      = 74
	DestinyActivityModeTypeGambitPrime             = 75
	DestinyActivityModeTypeReckoning               = 76
	DestinyActivityModeTypeMenagerie               = 77
	DestinyActivityModeTypeVexOffensive            = 78
	DestinyActivityModeTypeNightmareHunt           = 79
	DestinyActivityModeTypeElimination             = 80
	DestinyActivityModeTypeMomentum                = 81
	DestinyActivityModeTypeDungeon                 = 82
	DestinyActivityModeTypeSundial                 = 83
	DestinyActivityModeTypeTrialsOfOsiris          = 84
)
