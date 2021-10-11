package bungieapigo

// As you run into items that need to be classified for Milestone purposes in ways that we cannot
// infer via direct data, add a new classification here and use a string constant to represent it in
// the local item config file.
// NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1
// that may or may not still exist.
type SpecialItemType int

const (
	SpecialItemTypeNone             = 0
	SpecialItemTypeSpecialCurrency  = 1
	SpecialItemTypeArmor            = 8
	SpecialItemTypeWeapon           = 9
	SpecialItemTypeEngram           = 23
	SpecialItemTypeConsumable       = 24
	SpecialItemTypeExchangeMaterial = 25
	SpecialItemTypeMissionReward    = 27
	SpecialItemTypeCurrency         = 29
)
