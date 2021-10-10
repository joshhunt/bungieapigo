package bungieAPI

type DestinyItemPlugBase struct {

	// The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
	PlugItemHash int `json:"plugItemHash"`

	// If true, this plug has met all of its insertion requirements. Big if true.
	CanInsert bool `json:"canInsert"`

	// If true, this plug will provide its benefits while inserted.
	Enabled bool `json:"enabled"`

	// If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition's plug.insertionRules property, so you can show the reasons why it can't be inserted.
	// This list will be empty if the plug can be inserted.
	InsertFailIndexes []int `json:"insertFailIndexes"`

	// If a plug is not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.
	// This list will be empty if the plug is enabled.
	EnableFailIndexes []int `json:"enableFailIndexes"`
}
