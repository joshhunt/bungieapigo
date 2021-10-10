package bungieAPI

// Data related to what happens while a plug is being inserted, mostly for UI purposes.
type DestinyInsertPlugActionDefinition struct {

	// How long it takes for the Plugging of the item to be completed once it is initiated, if you care.
	ActionExecuteSeconds int `json:"actionExecuteSeconds"`

	// The type of action being performed when you act on this Socket Type. The most common value is "insert plug", but there are others as well (for instance, a "Masterwork" socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)
	ActionType SocketTypeActionType `json:"actionType"`
}
