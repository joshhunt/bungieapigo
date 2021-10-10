package bungieAPI

// An enumeration that indicates the high-level "type" of the item, attempting to iron out the
// context specific differences for specific instances of an entity. For instance, though a
// weapon may be of various weapon "Types", in DestinyItemType they are all classified as
// "Weapon". This allows for better filtering on a higher level of abstraction for the concept of
// types.
//  This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is
// to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories
// property instead. Item Categories allow for arbitrary hierarchies of specificity, and for
// items to belong to multiple categories across multiple hierarchies simultaneously. For this
// enum, we pick a single type as a "best guess" fit.
//  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1
// that may or may not still exist.
//  I keep updating these because they're so damn convenient. I guess I shouldn't fight it.
type DestinyItemType int

const (
	DestinyItemTypeNone              = 0
	DestinyItemTypeCurrency          = 1
	DestinyItemTypeArmor             = 2
	DestinyItemTypeWeapon            = 3
	DestinyItemTypeMessage           = 7
	DestinyItemTypeEngram            = 8
	DestinyItemTypeConsumable        = 9
	DestinyItemTypeExchangeMaterial  = 10
	DestinyItemTypeMissionReward     = 11
	DestinyItemTypeQuestStep         = 12
	DestinyItemTypeQuestStepComplete = 13
	DestinyItemTypeEmblem            = 14
	DestinyItemTypeQuest             = 15
	DestinyItemTypeSubclass          = 16
	DestinyItemTypeClanBanner        = 17
	DestinyItemTypeAura              = 18
	DestinyItemTypeMod               = 19
	DestinyItemTypeDummy             = 20
	DestinyItemTypeShip              = 21
	DestinyItemTypeVehicle           = 22
	DestinyItemTypeEmote             = 23
	DestinyItemTypeGhost             = 24
	DestinyItemTypePackage           = 25
	DestinyItemTypeBounty            = 26
	DestinyItemTypeWrapper           = 27
	DestinyItemTypeSeasonalArtifact  = 28
	DestinyItemTypeFinisher          = 29
)
