package bungieAPI

// Items like Sacks or Boxes can have items that it shows in-game when you view details that represent the items you can obtain if you use or acquire the item.
// This defines those categories, and gives some insights into that data's source.
type DestinyItemPreviewBlockDefinition struct {

	// A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there's no guarantees of a fixed, known number of these - so fall back to something reasonable if you don't recognize it.
	ScreenStyle string `json:"screenStyle"`

	// If the preview data is derived from a fake "Preview" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
	PreviewVendorHash int `json:"previewVendorHash"`

	// If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.
	ArtifactHash int `json:"artifactHash"`

	// If the preview has an associated action (like "Open"), this will be the localized string for that action.
	PreviewActionString string `json:"previewActionString"`

	// This is a list of the items being previewed, categorized in the same way as they are in the preview UI.
	DerivedItemCategories []DestinyDerivedItemCategoryDefinition `json:"derivedItemCategories"`
}
