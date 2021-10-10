package bungieAPI

type DestinyKioskItem struct {

	// The index of the item in the related DestinyVendorDefintion's itemList property, representing the sale.
	Index int `json:"index"`

	// If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.
	CanAcquire bool `json:"canAcquire"`

	// Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.
	FailureIndexes []int `json:"failureIndexes"`

	// I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for "flavor" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
	FlavorObjective DestinyObjectiveProgress `json:"flavorObjective"`
}
