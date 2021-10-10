package bungieAPI

// The set of all email subscription/opt-in settings and definitions.
type EmailSettings struct {

	// Keyed by the name identifier of the opt-in definition.
	OptInDefinitions map[string]EmailOptInDefinition `json:"optInDefinitions"`

	// Keyed by the name identifier of the Subscription definition.
	SubscriptionDefinitions map[string]EmailSubscriptionDefinition `json:"subscriptionDefinitions"`

	// Keyed by the name identifier of the View definition.
	Views map[string]EmailViewDefinition `json:"views"`
}
