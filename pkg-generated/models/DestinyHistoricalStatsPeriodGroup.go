package bungieapigo
import "time"

type DestinyHistoricalStatsPeriodGroup struct {

    // Period for the group. If the stat periodType is day, then this will have a specific day. If the
    // type is monthly, then this value will be the first day of the applicable month. This value is not
    // set when the periodType is 'all time'.
    Period time.Time `json:"period"`


    // If the period group is for a specific activity, this property will be set.
    ActivityDetails DestinyHistoricalStatsActivity `json:"activityDetails"`


    // Collection of stats for the period.
    Values map[string]DestinyHistoricalStatsValue `json:"values"`

}

