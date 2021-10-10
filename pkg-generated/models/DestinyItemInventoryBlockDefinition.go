package bungieAPI

// If the item can exist in an inventory - the overwhelming majority of them can and do - then this is
// the basic properties regarding the item's relationship with the inventory.
type DestinyItemInventoryBlockDefinition struct {

	// If this string is populated, you can't have more than one stack with this label in a given
	// inventory. Note that this is different from the equipping block's unique label, which is used
	// for equipping uniqueness.
	StackUniqueLabel string `json:"stackUniqueLabel"`

	// The maximum quantity of this item that can exist in a stack.
	MaxStackSize int `json:"maxStackSize"`

	// The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I
	// should have named this "bucketHash", but too many things refer to it now. Sigh.
	BucketTypeHash int `json:"bucketTypeHash"`

	// If the item is picked up by the lost loot queue, this is the hash identifier for the
	// DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named
	// this recoveryBucketHash instead.
	RecoveryBucketTypeHash int `json:"recoveryBucketTypeHash"`

	// The hash identifier for the Tier Type of the item, use to look up its
	// DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.
	TierTypeHash int `json:"tierTypeHash"`

	// If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a
	// stack (like Glimmer).
	IsInstanceItem bool `json:"isInstanceItem"`

	// The localized name of the tier type, which is a useful shortcut so you don't have to look up the
	// definition every time. However, it's mostly a holdover from days before we had a
	// DestinyItemTierTypeDefinition to refer to.
	TierTypeName string `json:"tierTypeName"`

	// The enumeration matching the tier type of the item to known values, again for convenience sake.
	TierType TierType `json:"tierType"`

	// The tooltip message to show, if any, when the item expires.
	ExpirationTooltip string `json:"expirationTooltip"`

	// If the item expires while playing in an activity, we show a different message.
	ExpiredInActivityMessage string `json:"expiredInActivityMessage"`

	// If the item expires in orbit, we show a... more different message. ("Consummate V's,
	// consummate!")
	ExpiredInOrbitMessage string `json:"expiredInOrbitMessage"`

	SuppressExpirationWhenObjectivesComplete bool `json:"suppressExpirationWhenObjectivesComplete"`
}
