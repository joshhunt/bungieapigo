package bungieAPI

import "time"

type TrendingEntryDestinyRitual struct {
	Image     string    `json:"image"`
	Icon      string    `json:"icon"`
	Title     string    `json:"title"`
	Subtitle  string    `json:"subtitle"`
	DateStart time.Time `json:"dateStart"`
	DateEnd   time.Time `json:"dateEnd"`

	// A destiny event does not necessarily have a related Milestone, but if it does the details will be
	// returned here.
	MilestoneDetails DestinyPublicMilestone `json:"milestoneDetails"`

	// A destiny event will not necessarily have milestone "custom content", but if it does the
	// details will be here.
	EventContent DestinyMilestoneContent `json:"eventContent"`
}
