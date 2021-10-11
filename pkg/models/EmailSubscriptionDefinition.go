package bungieapigo

// Defines a single subscription: permission to send emails for a specific, focused subject
// (generally timeboxed, such as for a specific release of a product or feature).
type EmailSubscriptionDefinition struct {

	// The unique identifier for this subscription.
	Name string `json:"name"`

	// A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.
	Localization map[string]EMailSettingSubscriptionLocalization `json:"localization"`

	// The bitflag value for this subscription. Should be a unique power of two value.
	Value int64 `json:"value"`
}
