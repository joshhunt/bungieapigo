package bungieapigo

// The reasons why an item cannot be equipped, if any. Many flags can be set, or "None" if
type EquipFailureReason int

const (

	// The item is/was able to be equipped.
	EquipFailureReasonNone = 0

	// This is not the kind of item that can be equipped. Did you try equipping Glimmer or something?
	EquipFailureReasonItemUnequippable = 1

	// This item is part of a "unique set", and you can't have more than one item of that same set type
	// equipped at once. For instance, if you already have an Exotic Weapon equipped, you can't equip a
	// second one in another weapon slot.
	EquipFailureReasonItemUniqueEquipRestricted = 2

	// This item has state-based gating that prevents it from being equipped in certain
	// circumstances. For instance, an item might be for Warlocks only and you're a Titan, or it might
	// require you to have beaten some special quest that you haven't beaten yet. Use the additional
	// failure data passed on the item itself to get more information about what the specific failure
	// case was (See DestinyInventoryItemDefinition and DestinyItemInstanceComponent)
	EquipFailureReasonItemFailedUnlockCheck = 4

	// This item requires you to have reached a specific character level in order to equip it, and you
	// haven't reached that level yet.
	EquipFailureReasonItemFailedLevelCheck = 8

	// This item can't be equipped on the character requested, because it must be in that character's
	// inventory first. Transfer the item to the character you want to equip it before you attempt to
	// equip it.
	EquipFailureReasonItemNotOnCharacter = 16
)
