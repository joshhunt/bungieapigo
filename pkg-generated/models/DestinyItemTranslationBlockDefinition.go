package bungieapigo

// This Block defines the rendering data associated with the item, if any.
type DestinyItemTranslationBlockDefinition struct {
    WeaponPatternIdentifier string `json:"weaponPatternIdentifier"`
    WeaponPatternHash int `json:"weaponPatternHash"`
    DefaultDyes []DyeReference `json:"defaultDyes"`
    LockedDyes []DyeReference `json:"lockedDyes"`
    CustomDyes []DyeReference `json:"customDyes"`
    Arrangements []DestinyGearArtArrangementReference `json:"arrangements"`
    HasGeometry bool `json:"hasGeometry"`
}

