package bungieAPI

type TrendingEntryDestinyActivity struct {
	ActivityHash int `json:"activityHash"`

	// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character's progress in it.
	Status DestinyPublicActivityStatus `json:"status"`
}
