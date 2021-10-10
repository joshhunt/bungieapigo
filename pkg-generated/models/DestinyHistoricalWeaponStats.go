package bungieAPI

type DestinyHistoricalWeaponStats struct {

	// The hash ID of the item definition that describes the weapon.
	ReferenceId int `json:"referenceId"`

	// Collection of stats for the period.
	Values map[string]DestinyHistoricalStatsValue `json:"values"`
}
