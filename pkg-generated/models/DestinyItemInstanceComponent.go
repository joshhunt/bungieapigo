package bungieapigo

// If an item is "instanced", this will contain information about the item's instance that
// doesn't fit easily into other components. One might say this is the "essential" instance data
// for the item.
// Items are instanced if they require information or state that can vary. For instance, weapons
// are Instanced: they are given a unique identifier, uniquely generated stats, and can have
// their properties altered. Non-instanced items have none of these things: for instance,
// Glimmer has no unique properties aside from how much of it you own.
// You can tell from an item's definition whether it will be instanced or not by looking at the
// DestinyInventoryItemDefinition's definition.inventory.isInstanceItem property.
type DestinyItemInstanceComponent struct {

    // If the item has a damage type, this is the item's current damage type.
    DamageType DamageType `json:"damageType"`


    // The current damage type's hash, so you can look up localized info and icons for it.
    DamageTypeHash int `json:"damageTypeHash"`


    // The item stat that we consider to be "primary" for the item. For instance, this would be "Attack"
    // for Weapons or "Defense" for armor.
    PrimaryStat DestinyStat `json:"primaryStat"`


    // The Item's "Level" has the most significant bearing on its stats, such as Light and Power.
    ItemLevel int `json:"itemLevel"`


    // The "Quality" of the item has a lesser - but still impactful - bearing on stats like Light and
    // Power.
    Quality int `json:"quality"`


    // Is the item currently equipped on the given character?
    IsEquipped bool `json:"isEquipped"`


    // If this is an equippable item, you can check it here. There are permanent as well as transitory
    // reasons why an item might not be able to be equipped: check cannotEquipReason for details.
    CanEquip bool `json:"canEquip"`


    // If the item cannot be equipped until you reach a certain level, that level will be reflected
    // here.
    EquipRequiredLevel int `json:"equipRequiredLevel"`


    // Sometimes, there are limitations to equipping that are represented by character-level flags
    // called "unlocks".
    // This is a list of flags that they need in order to equip the item that the character has not met. Use
    // these to look up the descriptions to show in your UI by looking up the relevant
    // DestinyUnlockDefinitions for the hashes.
    UnlockHashesRequiredToEquip []int `json:"unlockHashesRequiredToEquip"`


    // If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you
    // couldn't equip the item. You may need to refine your UI further by using
    // unlockHashesRequiredToEquip and equipRequiredLevel.
    CannotEquipReason EquipFailureReason `json:"cannotEquipReason"`


    // If populated, this item has a breaker type corresponding to the given value. See
    // DestinyBreakerTypeDefinition for more details.
    BreakerType int `json:"breakerType"`


    // If populated, this is the hash identifier for the item's breaker type. See
    // DestinyBreakerTypeDefinition for more details.
    BreakerTypeHash int `json:"breakerTypeHash"`


    // IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current
    // details of its energy type and available capacity to spend energy points.
    Energy DestinyItemInstanceEnergy `json:"energy"`

}

