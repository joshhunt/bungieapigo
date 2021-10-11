package bungieapigo

// Primarily for Quests, this is the definition of properties related to the item if it is a quest
// and its various quest steps.
type DestinyItemSetBlockDefinition struct {

	// A collection of hashes of set items, for items such as Quest Metadata items that possess this
	// data.
	ItemList []DestinyItemSetBlockEntryDefinition `json:"itemList"`

	// If true, items in the set can only be added in increasing order, and adding an item will remove any
	// previous item. For Quests, this is by necessity true. Only one quest step is present at a time,
	// and previous steps are removed as you advance in the quest.
	RequireOrderedSetItemAdd bool `json:"requireOrderedSetItemAdd"`

	// If true, the UI should treat this quest as "featured"
	SetIsFeatured bool `json:"setIsFeatured"`

	// A string identifier we can use to attempt to identify the category of the Quest.
	SetType string `json:"setType"`

	// The name of the quest line that this quest step is a part of.
	QuestLineName string `json:"questLineName"`

	// The description of the quest line that this quest step is a part of.
	QuestLineDescription string `json:"questLineDescription"`

	// An additional summary of this step in the quest line.
	QuestStepSummary string `json:"questStepSummary"`
}
