package bungieAPI

// All Sockets have a "Type": a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.
// See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.
type DestinySocketTypeDefinition struct {

	// There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// Defines what happens when a plug is inserted into sockets of this type.
	InsertAction DestinyInsertPlugActionDefinition `json:"insertAction"`

	// A list of Plug "Categories" that are allowed to be plugged into sockets of this type.
	// These should be compared against a given plug item's DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item's category.
	// If the plug's category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.
	PlugWhitelist      []DestinyPlugWhitelistEntryDefinition `json:"plugWhitelist"`
	SocketCategoryHash int                                   `json:"socketCategoryHash"`

	// Sometimes a socket isn't visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.
	Visibility                 DestinySocketVisibility `json:"visibility"`
	AlwaysRandomizeSockets     bool                    `json:"alwaysRandomizeSockets"`
	IsPreviewEnabled           bool                    `json:"isPreviewEnabled"`
	HideDuplicateReusablePlugs bool                    `json:"hideDuplicateReusablePlugs"`

	// This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item's icon and nameplate.
	OverridesUiAppearance           bool                                              `json:"overridesUiAppearance"`
	AvoidDuplicatesOnInitialization bool                                              `json:"avoidDuplicatesOnInitialization"`
	CurrencyScalars                 []DestinySocketTypeScalarMaterialRequirementEntry `json:"currencyScalars"`

	// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
	// When entities refer to each other in Destiny content, it is this hash that they are referring to.
	Hash int `json:"hash"`

	// The index of the entity as it was found in the investment tables.
	Index int `json:"index"`

	// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
	Redacted bool `json:"redacted"`
}
