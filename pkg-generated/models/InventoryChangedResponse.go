package bungieapigo

// A response containing all of the components for all requested vendors.
type InventoryChangedResponse struct {

    // Items that appeared in the inventory possibly as a result of an action.
    AddedInventoryItems []DestinyItemComponent `json:"addedInventoryItems"`


    // Items that disappeared from the inventory possibly as a result of an action.
    RemovedInventoryItems []DestinyItemComponent `json:"removedInventoryItems"`

}

