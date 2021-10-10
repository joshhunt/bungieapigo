package bungieAPI

type DestinyRecordIntervalBlock struct {
	IntervalObjectives                   []DestinyRecordIntervalObjective `json:"intervalObjectives"`
	IntervalRewards                      []DestinyRecordIntervalRewards   `json:"intervalRewards"`
	OriginalObjectiveArrayInsertionIndex int                              `json:"originalObjectiveArrayInsertionIndex"`
}
