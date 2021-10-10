package bungieAPI

type DestinyProgressionRewardItemQuantity struct {
	RewardedAtProgressionLevel int                                             `json:"rewardedAtProgressionLevel"`
	AcquisitionBehavior        DestinyProgressionRewardItemAcquisitionBehavior `json:"acquisitionBehavior"`
	UiDisplayStyle             string                                          `json:"uiDisplayStyle"`
	ClaimUnlockDisplayStrings  []string                                        `json:"claimUnlockDisplayStrings"`

	// The hash identifier for the item in question. Use it to look up the item's
	// DestinyInventoryItemDefinition.
	ItemHash int `json:"itemHash"`

	// If this quantity is referring to a specific instance of an item, this will have the item's
	// instance ID. Normally, this will be null.
	ItemInstanceId int64 `json:"itemInstanceId"`

	// The amount of the item needed/available depending on the context of where
	// DestinyItemQuantity is being used.
	Quantity int `json:"quantity"`

	// Indicates that this item quantity may be conditionally shown or hidden, based on various
	// sources of state. For example: server flags, account state, or character progress.
	HasConditionalVisibility bool `json:"hasConditionalVisibility"`
}
