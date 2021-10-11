package bungieapigo

// Dictates a rule around whether the plug is enabled or insertable.
// In practice, the live Destiny data will refer to these entries by index. You can then look up that
// index in the appropriate property (enabledRules or insertionRules) to get the localized
// string for the failure message if it failed.
type DestinyPlugRuleDefinition struct {

	// The localized string to show if this rule fails.
	FailureMessage string `json:"failureMessage"`
}
