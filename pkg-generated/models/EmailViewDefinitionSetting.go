package bungieAPI

type EmailViewDefinitionSetting struct {

	// The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.
	Name string `json:"name"`

	// A dictionary of localized text for the EMail setting, keyed by the locale.
	Localization map[string]EMailSettingLocalization `json:"localization"`

	// If true, this setting should be set by default if the user hasn't chosen whether it's set or cleared yet.
	SetByDefault bool `json:"setByDefault"`

	// The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.
	OptInAggregateValue OptInFlags `json:"optInAggregateValue"`

	// The subscriptions to show as children of this setting, if any.
	Subscriptions []EmailSubscriptionDefinition `json:"subscriptions"`
}
