package bungieAPI

// A set of flags for reason(s) why the component populated in the way that it did. Inspect the
// individual flags for the reasons.
type ComponentPrivacySetting int

const (
	ComponentPrivacySettingNone    = 0
	ComponentPrivacySettingPublic  = 1
	ComponentPrivacySettingPrivate = 2
)
