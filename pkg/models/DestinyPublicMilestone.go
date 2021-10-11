package bungieapigo

import "time"

// Information about milestones, presented in a character state-agnostic manner. Combine this
// data with DestinyMilestoneDefinition to get a full picture of the milestone, which is
// basically a checklist of things to do in the game. Think of this as GetPublicAdvisors 3.0, for
// those who used the Destiny 1 API.
type DestinyPublicMilestone struct {

	// The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for
	// static data about the Milestone.
	MilestoneHash int `json:"milestoneHash"`

	// A milestone not need have even a single quest, but if there are active quests they will be
	// returned here.
	AvailableQuests []DestinyPublicMilestoneQuest `json:"availableQuests"`

	Activities []DestinyPublicMilestoneChallengeActivity `json:"activities"`

	// Sometimes milestones - or activities active in milestones - will have relevant vendors. These
	// are the vendors that are currently relevant.
	// Deprecated, already, for the sake of the new "vendors" property that has more data. What was I
	// thinking.
	VendorHashes []int `json:"vendorHashes"`

	// This is why we can't have nice things. This is the ordered list of vendors to be shown that relate
	// to this milestone, potentially along with other interesting data.
	Vendors []DestinyPublicMilestoneVendor `json:"vendors"`

	// If known, this is the date when the Milestone started/became active.
	StartDate time.Time `json:"startDate"`

	// If known, this is the date when the Milestone will expire/recycle/end.
	EndDate time.Time `json:"endDate"`

	// Used for ordering milestones in a display to match how we order them in BNet. May pull from static
	// data, or possibly in the future from dynamic information.
	Order int `json:"order"`
}
