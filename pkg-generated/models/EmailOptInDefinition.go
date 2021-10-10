package bungieAPI

// Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.
type EmailOptInDefinition struct {

	// The unique identifier for this opt-in category.
	Name string `json:"name"`

	// The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.
	Value OptInFlags `json:"value"`

	// If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they're opting into.
	SetByDefault bool `json:"setByDefault"`

	// Information about the dependent subscriptions for this opt-in.
	DependentSubscriptions []EmailSubscriptionDefinition `json:"dependentSubscriptions"`
}
