package bungieapigo

// Represents localized, extended content related to Milestones. This is intentionally
// returned by a separate endpoint and not with Character-level Milestone data because we do not
// put localized data into standard Destiny responses, both for brevity of response and for
// caching purposes. If you really need this data, hit the Milestone Content endpoint.
type DestinyMilestoneContent struct {

    // The "About this Milestone" text from the Firehose.
    About string `json:"about"`


    // The Current Status of the Milestone, as driven by the Firehose.
    Status string `json:"status"`


    // A list of tips, provided by the Firehose.
    Tips []string `json:"tips"`


    // If DPS has defined items related to this Milestone, they can categorize those items in the
    // Firehose. That data will then be returned as item categories here.
    ItemCategories []DestinyMilestoneContentItemCategory `json:"itemCategories"`

}

