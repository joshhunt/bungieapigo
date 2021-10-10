package bungieAPI

// Information about the category and items currently sold in that category.
type DestinyVendorCategory struct {

	// An index into the DestinyVendorDefinition.displayCategories property, so you can grab the
	// display data for this category.
	DisplayCategoryIndex int `json:"displayCategoryIndex"`

	// An ordered list of indexes into items being sold in this category
	// (DestinyVendorDefinition.itemList) which will contain more information about the items
	// being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data,
	// if you asked for that data to be returned.
	ItemIndexes []int `json:"itemIndexes"`
}
