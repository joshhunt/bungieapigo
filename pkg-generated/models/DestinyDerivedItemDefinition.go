package bungieapigo

// This is a reference to, and summary data for, a specific item that you can get as a result of Using
// or Acquiring some other Item (For example, this could be summary information for an Emote that
// you can get by opening an an Eververse Box) See DestinyDerivedItemCategoryDefinition for
// more information.
type DestinyDerivedItemDefinition struct {

    // The hash for the DestinyInventoryItemDefinition of this derived item, if there is one.
    // Sometimes we are given this information as a manual override, in which case there won't be an
    // actual DestinyInventoryItemDefinition for what we display, but you can still show the
    // strings from this object itself.
    ItemHash int `json:"itemHash"`


    // The name of the derived item.
    ItemName string `json:"itemName"`


    // Additional details about the derived item, in addition to the description.
    ItemDetail string `json:"itemDetail"`


    // A brief description of the item.
    ItemDescription string `json:"itemDescription"`


    // An icon for the item.
    IconPath string `json:"iconPath"`


    // If the item was derived from a "Preview Vendor", this will be an index into the
    // DestinyVendorDefinition's itemList property. Otherwise, -1.
    VendorItemIndex int `json:"vendorItemIndex"`

}

