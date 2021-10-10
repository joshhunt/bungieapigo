package bungieAPI

// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The "Sub-Type" is where we classify and categorize items one step further in specificity: "Auto Rifle" instead of just "Weapon" for example, or "Vanguard Bounty" instead of merely "Bounty".
// These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a "best guess" fit.
// NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
type DestinyItemSubType int

const (
	DestinyItemSubTypeNone = 0

	// DEPRECATED. Items can be both "Crucible" and something else interesting.
	DestinyItemSubTypeCrucible = 1

	// DEPRECATED. An item can both be "Vanguard" and something else.
	DestinyItemSubTypeVanguard = 2

	// DEPRECATED. An item can both be Exotic and something else.
	DestinyItemSubTypeExotic         = 5
	DestinyItemSubTypeAutoRifle      = 6
	DestinyItemSubTypeShotgun        = 7
	DestinyItemSubTypeMachinegun     = 8
	DestinyItemSubTypeHandCannon     = 9
	DestinyItemSubTypeRocketLauncher = 10
	DestinyItemSubTypeFusionRifle    = 11
	DestinyItemSubTypeSniperRifle    = 12
	DestinyItemSubTypePulseRifle     = 13
	DestinyItemSubTypeScoutRifle     = 14

	// DEPRECATED. An item can both be CRM and something else.
	DestinyItemSubTypeCrm                   = 16
	DestinyItemSubTypeSidearm               = 17
	DestinyItemSubTypeSword                 = 18
	DestinyItemSubTypeMask                  = 19
	DestinyItemSubTypeShader                = 20
	DestinyItemSubTypeOrnament              = 21
	DestinyItemSubTypeFusionRifleLine       = 22
	DestinyItemSubTypeGrenadeLauncher       = 23
	DestinyItemSubTypeSubmachineGun         = 24
	DestinyItemSubTypeTraceRifle            = 25
	DestinyItemSubTypeHelmetArmor           = 26
	DestinyItemSubTypeGauntletsArmor        = 27
	DestinyItemSubTypeChestArmor            = 28
	DestinyItemSubTypeLegArmor              = 29
	DestinyItemSubTypeClassArmor            = 30
	DestinyItemSubTypeBow                   = 31
	DestinyItemSubTypeDummyRepeatableBounty = 32
)
