package bungieAPI

// If a vendor can ever end up performing actions, these are the properties that will be related to those actions. I'm not going to bother documenting this yet, as it is unused and unclear if it will ever be used... but in case it is ever populated and someone finds it useful, it is defined here.
type DestinyVendorActionDefinition struct {
	Description       string `json:"description"`
	ExecuteSeconds    int    `json:"executeSeconds"`
	Icon              string `json:"icon"`
	Name              string `json:"name"`
	Verb              string `json:"verb"`
	IsPositive        bool   `json:"isPositive"`
	ActionId          string `json:"actionId"`
	ActionHash        int    `json:"actionHash"`
	AutoPerformAction bool   `json:"autoPerformAction"`
}
