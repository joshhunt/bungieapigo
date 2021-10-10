package bungieAPI

type SingleComponentResponseOfDestinyItemSocketsComponent struct {

	// Instanced items can have sockets, which are slots on the item where plugs can be inserted.
	// Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition's "socket" block and elsewhere on these objects for more details.
	Data    DestinyItemSocketsComponent `json:"data"`
	Privacy ComponentPrivacySetting     `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
