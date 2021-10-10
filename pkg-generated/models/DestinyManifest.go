package bungieAPI

// DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform.
type DestinyManifest struct {
	Version                  string                        `json:"version"`
	MobileAssetContentPath   string                        `json:"mobileAssetContentPath"`
	MobileGearAssetDataBases []GearAssetDataBaseDefinition `json:"mobileGearAssetDataBases"`
	MobileWorldContentPaths  map[string]string             `json:"mobileWorldContentPaths"`

	// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)
	JsonWorldContentPaths map[string]string `json:"jsonWorldContentPaths"`

	// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.
	JsonWorldComponentContentPaths map[string]map[string]string `json:"jsonWorldComponentContentPaths"`
	MobileClanBannerDatabasePath   string                       `json:"mobileClanBannerDatabasePath"`
	MobileGearCdn                  map[string]string            `json:"mobileGearCDN"`

	// Information about the "Image Pyramid" for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the "original/full size" Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)
	IconImagePyramidInfo []ImagePyramidEntry `json:"iconImagePyramidInfo"`
}
