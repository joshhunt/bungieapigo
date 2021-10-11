package bungieapigo

// Represents all of the data related to a single plug to be inserted.
// Note that, while you *can* point to a socket that represents infusion, you will receive an error
// if you attempt to do so. Come on guys, let's play nice.
type DestinyInsertPlugsRequestEntry struct {

	// The index into the socket array, which identifies the specific socket being operated on. We
	// also need to know the socketArrayType in order to uniquely identify the socket.
	// Don't point to or try to insert a plug into an infusion socket. It won't work.
	SocketIndex int `json:"socketIndex"`

	// This property, combined with the socketIndex, tells us which socket we are referring to (since
	// operations can be performed on both Intrinsic and "default" sockets, and they occupy
	// different arrays in the Inventory Item Definition). I know, I know. Don't give me that look.
	SocketArrayType DestinySocketArrayType `json:"socketArrayType"`

	// Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1)
	// Infer whether the player actually needs to have the item, or if it's a reusable plug 2) Perform
	// any operation needed to use the Plug, including removing the plug item and running reward
	// sheets.
	PlugItemHash int `json:"plugItemHash"`
}
