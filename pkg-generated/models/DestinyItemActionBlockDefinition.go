package bungieAPI

// If an item can have an action performed on it (like "Dismantle"), it will be defined here if you care.
type DestinyItemActionBlockDefinition struct {

	// Localized text for the verb of the action being performed.
	VerbName string `json:"verbName"`

	// Localized text describing the action being performed.
	VerbDescription string `json:"verbDescription"`

	// The content has this property, however it's not entirely clear how it is used.
	IsPositive bool `json:"isPositive"`

	// If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen's data itself.
	OverlayScreenName string `json:"overlayScreenName"`

	// The icon associated with the overlay screen for the action, if any.
	OverlayIcon string `json:"overlayIcon"`

	// The number of seconds to delay before allowing this action to be performed again.
	RequiredCooldownSeconds int `json:"requiredCooldownSeconds"`

	// If the action requires other items to exist or be destroyed, this is the list of those items and requirements.
	RequiredItems []DestinyItemActionRequiredItemDefinition `json:"requiredItems"`

	// If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.
	ProgressionRewards []DestinyProgressionRewardDefinition `json:"progressionRewards"`

	// The internal identifier for the action.
	ActionTypeLabel string `json:"actionTypeLabel"`

	// Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.
	RequiredLocation string `json:"requiredLocation"`

	// The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.
	RequiredCooldownHash int `json:"requiredCooldownHash"`

	// If true, the item is deleted when the action completes.
	DeleteOnAction bool `json:"deleteOnAction"`

	// If true, the entire stack is deleted when the action completes.
	ConsumeEntireStack bool `json:"consumeEntireStack"`

	// If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.
	UseOnAcquire bool `json:"useOnAcquire"`
}
