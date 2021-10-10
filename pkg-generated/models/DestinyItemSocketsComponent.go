package bungieAPI

// Instanced items can have sockets, which are slots on the item where plugs can be inserted.
// Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition's "socket" block and elsewhere on these objects for more details.
type DestinyItemSocketsComponent struct {

	// The list of all sockets on the item, and their status information.
	Sockets []DestinyItemSocketState `json:"sockets"`
}
