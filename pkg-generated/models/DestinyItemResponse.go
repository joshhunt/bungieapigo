package bungieAPI

// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn't have an "itemInstanceId": for those, get your information from the DestinyInventoryDefinition.
type DestinyItemResponse struct {

	// If the item is on a character, this will return the ID of the character that is holding the item.
	CharacterId int64 `json:"characterId"`

	// Common data for the item relevant to its non-instanced properties.
	// COMPONENT TYPE: ItemCommonData
	Item SingleComponentResponseOfDestinyItemComponent `json:"item"`

	// Basic instance data for the item.
	// COMPONENT TYPE: ItemInstances
	Instance SingleComponentResponseOfDestinyItemInstanceComponent `json:"instance"`

	// Information specifically about the item's objectives.
	// COMPONENT TYPE: ItemObjectives
	Objectives SingleComponentResponseOfDestinyItemObjectivesComponent `json:"objectives"`

	// Information specifically about the perks currently active on the item.
	// COMPONENT TYPE: ItemPerks
	Perks SingleComponentResponseOfDestinyItemPerksComponent `json:"perks"`

	// Information about how to render the item in 3D.
	// COMPONENT TYPE: ItemRenderData
	RenderData SingleComponentResponseOfDestinyItemRenderComponent `json:"renderData"`

	// Information about the computed stats of the item: power, defense, etc...
	// COMPONENT TYPE: ItemStats
	Stats SingleComponentResponseOfDestinyItemStatsComponent `json:"stats"`

	// Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character's "Builds".
	// COMPONENT TYPE: ItemTalentGrids
	TalentGrid SingleComponentResponseOfDestinyItemTalentGridComponent `json:"talentGrid"`

	// Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.
	// COMPONENT TYPE: ItemSockets
	Sockets SingleComponentResponseOfDestinyItemSocketsComponent `json:"sockets"`

	// Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.
	//  These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.
	//  COMPONENT TYPE: ItemReusablePlugs
	ReusablePlugs SingleComponentResponseOfDestinyItemReusablePlugsComponent `json:"reusablePlugs"`

	// Information about objectives on Plugs for a given item. See the component's documentation for more info.
	// COMPONENT TYPE: ItemPlugObjectives
	PlugObjectives SingleComponentResponseOfDestinyItemPlugObjectivesComponent `json:"plugObjectives"`
}
