package bungieapigo

type DestinyItemChangeResponse struct {

    // The response object for retrieving an individual instanced item. None of these components are
    // relevant for an item that doesn't have an "itemInstanceId": for those, get your information
    // from the DestinyInventoryDefinition.
    Item DestinyItemResponse `json:"item"`


    // Items that appeared in the inventory possibly as a result of an action.
    AddedInventoryItems []DestinyItemComponent `json:"addedInventoryItems"`


    // Items that disappeared from the inventory possibly as a result of an action.
    RemovedInventoryItems []DestinyItemComponent `json:"removedInventoryItems"`

}

