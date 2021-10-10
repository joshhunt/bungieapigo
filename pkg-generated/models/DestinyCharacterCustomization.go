package bungieAPI

// Raw data about the customization options chosen for a character's face and appearance.
// You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
type DestinyCharacterCustomization struct {
	Personality   int   `json:"personality"`
	Face          int   `json:"face"`
	SkinColor     int   `json:"skinColor"`
	LipColor      int   `json:"lipColor"`
	EyeColor      int   `json:"eyeColor"`
	HairColors    []int `json:"hairColors"`
	FeatureColors []int `json:"featureColors"`
	DecalColor    int   `json:"decalColor"`
	WearHelmet    bool  `json:"wearHelmet"`
	HairIndex     int   `json:"hairIndex"`
	FeatureIndex  int   `json:"featureIndex"`
	DecalIndex    int   `json:"decalIndex"`
}
