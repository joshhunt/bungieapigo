package bungieapigo

// Represents a status string that could be conditionally displayed about an activity. Note that
// externally, you can only see the strings themselves. Internally we combine this information
// with server state to determine which strings should be shown.
type DestinyActivityUnlockStringDefinition struct {

	// The string to be displayed if the conditions are met.
	DisplayString string `json:"displayString"`
}
