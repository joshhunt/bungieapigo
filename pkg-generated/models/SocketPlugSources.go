package bungieAPI

// Indicates how a socket is populated, and where you should look for valid plug data.
//  This is a flags enumeration/bitmask field, as you may have to look in multiple sources across
// multiple components for valid plugs.
//  For instance, a socket could have plugs that are sourced from its own definition, as well as
// plugs that are sourced from Character-scoped AND profile-scoped Plug Sets. Only by combining
// plug data for every indicated source will you be able to know all of the plugs available for a
// socket.
type SocketPlugSources int

const (

	// If there's no way we can detect to insert new plugs.
	SocketPlugSourcesNone = 0

	// Use plugs found in the player's inventory, based on the socket type rules (see
	// DestinySocketTypeDefinition for more info)
	// Note that a socket - like Shaders - can have *both* reusable plugs and inventory items inserted
	// theoretically.
	SocketPlugSourcesInventorySourced = 1

	// Use the DestinyItemSocketsComponent.sockets.reusablePlugs property to determine which
	// plugs are valid for this socket. This may have to be combined with other sources, such as plug
	// sets, if those flags are set.
	//  Note that "Reusable" plugs may not necessarily come from a plug set, nor from the
	// "reusablePlugItems" in the socket's Definition data. They can sometimes be "randomized" in
	// which case the only source of truth at the moment is still the runtime
	// DestinyItemSocketsComponent.sockets.reusablePlugs property.
	SocketPlugSourcesReusablePlugItems = 2

	// Use the ProfilePlugSets (DestinyProfileResponse.profilePlugSets) component data to
	// determine which plugs are valid for this socket.
	SocketPlugSourcesProfilePlugSet = 4

	// Use the CharacterPlugSets (DestinyProfileResponse.characterPlugSets) component data to
	// determine which plugs are valid for this socket.
	SocketPlugSourcesCharacterPlugSet = 8
)
