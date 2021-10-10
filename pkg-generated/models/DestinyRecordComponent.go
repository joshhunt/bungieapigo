package bungieAPI

type DestinyRecordComponent struct {
	State                  DestinyRecordState         `json:"state"`
	Objectives             []DestinyObjectiveProgress `json:"objectives"`
	IntervalObjectives     []DestinyObjectiveProgress `json:"intervalObjectives"`
	IntervalsRedeemedCount int                        `json:"intervalsRedeemedCount"`

	// If available, this is the number of times this record has been completed. For example, the number of times a seal title has been gilded.
	CompletedCount int `json:"completedCount"`

	// If available, a list that describes which reward rewards should be shown (true) or hidden (false). This property is for regular record rewards, and not for interval objective rewards.
	RewardVisibilty []bool `json:"rewardVisibilty"`
}
