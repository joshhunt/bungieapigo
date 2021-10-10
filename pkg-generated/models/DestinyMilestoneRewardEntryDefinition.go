package bungieAPI

// The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.
type DestinyMilestoneRewardEntryDefinition struct {

	// The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.
	RewardEntryHash int `json:"rewardEntryHash"`

	// The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.
	RewardEntryIdentifier string `json:"rewardEntryIdentifier"`

	// The items you will get as rewards, and how much of it you'll get.
	Items []DestinyItemQuantity `json:"items"`

	// If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.
	VendorHash int `json:"vendorHash"`

	// For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// If you want to follow BNet's ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.
	Order int `json:"order"`
}
