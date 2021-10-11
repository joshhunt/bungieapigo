package bungieapigo

// The status of a given item's socket. (which plug is inserted, if any: whether it is enabled, what
// "reusable" plugs can be inserted, etc...)
// If I had it to do over, this would probably have a DestinyItemPlug representing the inserted
// item instead of most of these properties. :shrug:
type DestinyItemSocketState struct {

	// The currently active plug, if any.
	// Note that, because all plugs are statically defined, its effect on stats and perks can be
	// statically determined using the plug item's definition. The stats and perks can be taken at
	// face value on the plug item as the stats and perks it will provide to the user/item.
	PlugHash int `json:"plugHash"`

	// Even if a plug is inserted, it doesn't mean it's enabled.
	// This flag indicates whether the plug is active and providing its benefits.
	IsEnabled bool `json:"isEnabled"`

	// A plug may theoretically provide benefits but not be visible - for instance, some older items
	// use a plug's damage type perk to modify their own damage type. These, though they are not
	// visible, still affect the item. This field indicates that state.
	// An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by
	// the user.
	IsVisible bool `json:"isVisible"`

	// If a plug is inserted but not enabled, this will be populated with indexes into the plug item
	// definition's plug.enabledRules property, so that you can show the reasons why it is not
	// enabled.
	EnableFailIndexes []int `json:"enableFailIndexes"`
}
