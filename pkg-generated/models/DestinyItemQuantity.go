package bungieAPI

// Used in a number of Destiny contracts to return data about an item stack and its quantity. Can
// optionally return an itemInstanceId if the item is instanced - in which case, the quantity
// returned will be 1. If it's not... uh, let me know okay? Thanks.
type DestinyItemQuantity struct {

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
