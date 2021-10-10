package bungieapigo

// Localized text relevant to a given EMail setting in a given localization. Extra settings
// specifically for subscriptions.
type EMailSettingSubscriptionLocalization struct {
    UnknownUserDescription string `json:"unknownUserDescription"`
    RegisteredUserDescription string `json:"registeredUserDescription"`
    UnregisteredUserDescription string `json:"unregisteredUserDescription"`
    UnknownUserActionText string `json:"unknownUserActionText"`
    KnownUserActionText string `json:"knownUserActionText"`
    Title string `json:"title"`
    Description string `json:"description"`
}

