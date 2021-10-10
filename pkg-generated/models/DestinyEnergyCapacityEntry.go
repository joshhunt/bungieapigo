package bungieAPI

// Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much "Energy" can be spent on activating plugs for this item.
type DestinyEnergyCapacityEntry struct {

	// How much energy capacity this plug provides.
	CapacityValue int `json:"capacityValue"`

	// Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.
	EnergyTypeHash int `json:"energyTypeHash"`

	// The Energy Type for this energy capacity, in enum form for easy use.
	EnergyType DestinyEnergyType `json:"energyType"`
}
