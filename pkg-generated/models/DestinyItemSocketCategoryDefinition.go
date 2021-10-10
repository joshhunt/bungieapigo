package bungieAPI

// Sockets are grouped into categories in the UI. These define which category and which sockets
// are under that category.
type DestinyItemSocketCategoryDefinition struct {

	// The hash for the Socket Category: a quick way to go get the header display information for the
	// category. Use it to look up DestinySocketCategoryDefinition info.
	SocketCategoryHash int `json:"socketCategoryHash"`

	// Use these indexes to look up the sockets in the "sockets.socketEntries" property on the item
	// definition. These are the indexes under the category, in game-rendered order.
	SocketIndexes []int `json:"socketIndexes"`
}
