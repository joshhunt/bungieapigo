package bungieapigo

// In addition to item quantity information for vendor prices, this also has any optional
// information that may exist about how the item's quantity can be modified. (unfortunately not
// information that is able to be read outside of the BNet servers, but it's there)
type DestinyVendorItemQuantity struct {

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
