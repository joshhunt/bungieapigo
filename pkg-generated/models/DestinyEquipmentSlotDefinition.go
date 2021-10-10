package bungieapigo

// Characters can not only have Inventory buckets (containers of items that are generally
// matched by their type or functionality), they can also have Equipment Slots.
// The Equipment Slot is an indicator that the related bucket can have instanced items equipped on
// the character. For instance, the Primary Weapon bucket has an Equipment Slot that determines
// whether you can equip primary weapons, and holds the association between its slot and the
// inventory bucket from which it can have items equipped.
// An Equipment Slot must have a related Inventory Bucket, but not all inventory buckets must have
// Equipment Slots.
type DestinyEquipmentSlotDefinition struct {

    // Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
    // tables in the Manifest Database - also have displayable information. This is the base class for
    // that display information.
    DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`


    // These technically point to "Equipment Category Definitions". But don't get excited. There's
    // nothing of significant value in those definitions, so I didn't bother to expose them. You can
    // use the hash here to group equipment slots by common functionality, which serves the same
    // purpose as if we had the Equipment Category definitions exposed.
    EquipmentCategoryHash int `json:"equipmentCategoryHash"`


    // The inventory bucket that owns this equipment slot.
    BucketTypeHash int `json:"bucketTypeHash"`


    // If True, equipped items should have their custom art dyes applied when rendering the item.
    // Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.
    ApplyCustomArtDyes bool `json:"applyCustomArtDyes"`


    // The Art Dye Channels that apply to this equipment slot.
    ArtDyeChannels []DestinyArtDyeReference `json:"artDyeChannels"`


    // The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not
    // globally.
    // When entities refer to each other in Destiny content, it is this hash that they are referring to.
    Hash int `json:"hash"`


    // The index of the entity as it was found in the investment tables.
    Index int `json:"index"`


    // If this is true, then there is an entity with this identifier/type combination, but BNet is not
    // yet allowed to show it. Sorry!
    Redacted bool `json:"redacted"`

}

