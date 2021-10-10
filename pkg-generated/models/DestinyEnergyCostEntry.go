package bungieAPI

// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a "masterworks-like" mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
type DestinyEnergyCostEntry struct {

	// The Energy cost for inserting this plug.
	EnergyCost int `json:"energyCost"`

	// The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.
	EnergyTypeHash int `json:"energyTypeHash"`

	// The type of energy that this plug costs, in enum form.
	EnergyType DestinyEnergyType `json:"energyType"`
}
