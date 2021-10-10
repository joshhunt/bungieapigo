package bungieapigo

// Part of our dynamic, localized Milestone content is arbitrary categories of items. These are
// built in our content management system, and thus aren't the same as programmatically
// generated rewards.
type DestinyMilestoneContentItemCategory struct {
    Title string `json:"title"`
    ItemHashes []int `json:"itemHashes"`
}

