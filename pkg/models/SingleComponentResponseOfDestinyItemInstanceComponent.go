package bungieapigo

type SingleComponentResponseOfDestinyItemInstanceComponent struct {

	// If an item is "instanced", this will contain information about the item's instance that
	// doesn't fit easily into other components. One might say this is the "essential" instance data
	// for the item.
	// Items are instanced if they require information or state that can vary. For instance, weapons
	// are Instanced: they are given a unique identifier, uniquely generated stats, and can have
	// their properties altered. Non-instanced items have none of these things: for instance,
	// Glimmer has no unique properties aside from how much of it you own.
	// You can tell from an item's definition whether it will be instanced or not by looking at the
	// DestinyInventoryItemDefinition's definition.inventory.isInstanceItem property.
	Data DestinyItemInstanceComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
