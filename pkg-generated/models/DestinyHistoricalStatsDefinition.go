package bungieapigo

type DestinyHistoricalStatsDefinition struct {

    // Unique programmer friendly ID for this stat
    StatId string `json:"statId"`


    // Statistic group
    Group DestinyStatsGroupType `json:"group"`


    // Time periods the statistic covers
    PeriodTypes []PeriodType `json:"periodTypes"`


    // Game modes where this statistic can be reported.
    Modes []DestinyActivityModeType `json:"modes"`


    // Category for the stat.
    Category DestinyStatsCategoryType `json:"category"`


    // Display name
    StatName string `json:"statName"`


    // Display name abbreviated
    StatNameAbbr string `json:"statNameAbbr"`


    // Description of a stat if applicable.
    StatDescription string `json:"statDescription"`


    // Unit, if any, for the statistic
    UnitType UnitType `json:"unitType"`


    // Optional URI to an icon for the statistic
    IconImage string `json:"iconImage"`


    // Optional icon for the statistic
    MergeMethod int `json:"mergeMethod"`


    // Localized Unit Name for the stat.
    UnitLabel string `json:"unitLabel"`


    // Weight assigned to this stat indicating its relative impressiveness.
    Weight int `json:"weight"`


    // The tier associated with this medal - be it implicitly or explicitly.
    MedalTierHash int `json:"medalTierHash"`

}

