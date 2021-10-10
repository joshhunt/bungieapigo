package bungieAPI

// Data regarding the progress of a Quest for a specific character. Quests are composed of multiple steps, each with potentially multiple objectives: this QuestStatus will return Objective data for the *currently active* step in this quest.
type DestinyQuestStatus struct {

	// The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
	QuestHash int `json:"questHash"`

	// The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.
	StepHash int `json:"stepHash"`

	// A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.
	StepObjectives []DestinyObjectiveProgress `json:"stepObjectives"`

	// Whether or not the quest is tracked
	Tracked bool `json:"tracked"`

	// The current Quest Step will be an instanced item in the player's inventory. If you care about that, this is the instance ID of that item.
	ItemInstanceId int64 `json:"itemInstanceId"`

	// Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.
	Completed bool `json:"completed"`

	// Whether or not you have redeemed rewards for this quest.
	Redeemed bool `json:"redeemed"`

	// Whether or not you have started this quest.
	Started bool `json:"started"`

	// If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.
	VendorHash int `json:"vendorHash"`
}
