package bungieAPI

// The definition of a category of rewards, that contains many individual rewards.
type DestinyMilestoneRewardCategoryDefinition struct {

	// Identifies the reward category. Only guaranteed unique within this specific component!
	CategoryHash int `json:"categoryHash"`

	// The string identifier for the category, if you want to use it for some end. Guaranteed unique
	// within the specific component.
	CategoryIdentifier string `json:"categoryIdentifier"`

	// Hopefully this is obvious by now.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// If this milestone can provide rewards, this will define the sets of rewards that can be earned,
	// the conditions under which they can be acquired, internal data that we'll use at runtime to
	// determine whether you've already earned or redeemed this set of rewards, and the category that
	// this reward should be placed under.
	RewardEntries map[int]DestinyMilestoneRewardEntryDefinition `json:"rewardEntries"`

	// If you want to use BNet's recommended order for rendering categories programmatically, use
	// this value and compare it to other categories to determine the order in which they should be
	// rendered. I don't feel great about putting this here, I won't lie.
	Order int `json:"order"`
}
