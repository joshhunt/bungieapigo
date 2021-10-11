package bungieapigo

type DestinyPostGameCarnageReportExtendedData struct {

	// List of weapons and their perspective values.
	Weapons []DestinyHistoricalWeaponStats `json:"weapons"`

	// Collection of stats for the player in this activity.
	Values map[string]DestinyHistoricalStatsValue `json:"values"`
}
