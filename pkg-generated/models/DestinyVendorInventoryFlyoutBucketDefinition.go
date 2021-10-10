package bungieAPI

// Information about a single inventory bucket in a vendor flyout UI and how it is shown.
type DestinyVendorInventoryFlyoutBucketDefinition struct {

	// If true, the inventory bucket should be able to be collapsed visually.
	Collapsible bool `json:"collapsible"`

	// The inventory bucket whose contents should be shown.
	InventoryBucketHash int `json:"inventoryBucketHash"`

	// The methodology to use for sorting items from the flyout.
	SortItemsBy DestinyItemSortType `json:"sortItemsBy"`
}
