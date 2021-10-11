package bungieapigo

type DestinyItemInstanceEnergy struct {

	// The type of energy for this item. Plugs that require Energy can only be inserted if they have the
	// "Any" Energy Type or the matching energy type of this item. This is a reference to the
	// DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.
	EnergyTypeHash int `json:"energyTypeHash"`

	// This is the enum version of the Energy Type value, for convenience.
	EnergyType DestinyEnergyType `json:"energyType"`

	// The total capacity of Energy that the item currently has, regardless of if it is currently being
	// used.
	EnergyCapacity int `json:"energyCapacity"`

	// The amount of Energy currently in use by inserted plugs.
	EnergyUsed int `json:"energyUsed"`

	// The amount of energy still available for inserting new plugs.
	EnergyUnused int `json:"energyUnused"`
}
