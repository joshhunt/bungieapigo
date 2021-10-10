package bungieAPI

// Represents a socket that has a plug associated with it intrinsically. This is useful for
// situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should
// never change.
type DestinyItemIntrinsicSocketEntryDefinition struct {

	// Indicates the plug that is intrinsically inserted into this socket.
	PlugItemHash int `json:"plugItemHash"`

	// Indicates the type of this intrinsic socket.
	SocketTypeHash int `json:"socketTypeHash"`

	// If true, then this socket is visible in the item's "default" state. If you have an instance, you
	// should always check the runtime state, as that can override this visibility setting: but if
	// you're looking at the item on a conceptual level, this property can be useful for hiding data
	// such as legacy sockets - which remain defined on items for infrastructure purposes, but can be
	// confusing for users to see.
	DefaultVisible bool `json:"defaultVisible"`
}
