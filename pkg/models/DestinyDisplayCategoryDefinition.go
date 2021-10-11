package bungieapigo

// Display Categories are different from "categories" in that these are specifically for visual
// grouping and display of categories in Vendor UI. The "categories" structure is for validation
// of the contained items, and can be categorized entirely separately from "Display
// Categories", there need be and often will be no meaningful relationship between the two.
type DestinyDisplayCategoryDefinition struct {
	Index int `json:"index"`

	// A string identifier for the display category.
	Identifier string `json:"identifier"`

	DisplayCategoryHash int `json:"displayCategoryHash"`

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// If true, this category should be displayed in the "Banner" section of the vendor's UI.
	DisplayInBanner bool `json:"displayInBanner"`

	// If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents
	// the progression to show on this display category.
	// Specific categories can now have thier own distinct progression, apparently. So that's cool.
	ProgressionHash int `json:"progressionHash"`

	// If this category sorts items in a nonstandard way, this will be the way we sort.
	SortOrder VendorDisplayCategorySortOrder `json:"sortOrder"`

	// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or
	// interesting in response to this, or just to treat it as a normal category.
	DisplayStyleHash int `json:"displayStyleHash"`

	// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or
	// interesting in response to this, or just to treat it as a normal category.
	DisplayStyleIdentifier string `json:"displayStyleIdentifier"`
}
