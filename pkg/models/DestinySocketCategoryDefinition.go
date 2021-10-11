package bungieapigo

// Sockets on an item are organized into Categories visually.
// You can find references to the socket category defined on an item's
// DestinyInventoryItemDefinition.sockets.socketCategories property.
// This has the display information for rendering the categories' header, and a hint for how the UI
// should handle showing this category.
// The shitty thing about this, however, is that the socket categories' UI style can be overridden
// by the item's UI style. For instance, the Socket Category used by Emote Sockets says it's
// "consumable," but that's a lie: they're all reusable, and overridden by the detail UI pages in
// ways that we can't easily account for in the API.
// As a result, I will try to compile these rules into the individual sockets on items, and provide
// the best hint possible there through the plugSources property. In the future, I may attempt to
// use this information in conjunction with the item to provide a more usable UI hint on the socket
// layer, but for now improving the consistency of plugSources is the best I have time to provide.
// (See https://github.com/Bungie-net/api/issues/522 for more info)
type DestinySocketCategoryDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own
	// tables in the Manifest Database - also have displayable information. This is the base class for
	// that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// A string hinting to the game's UI system about how the sockets in this category should be
	// displayed.
	// BNet doesn't use it: it's up to you to find valid values and make your own special UI if you want to
	// honor this category style.
	UiCategoryStyle int `json:"uiCategoryStyle"`

	// Same as uiCategoryStyle, but in a more usable enumeration form.
	CategoryStyle DestinySocketCategoryStyle `json:"categoryStyle"`

	// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not
	// globally.
	// When entities refer to each other in Destiny content, it is this hash that they are referring to.
	Hash int `json:"hash"`

	// The index of the entity as it was found in the investment tables.
	Index int `json:"index"`

	// If this is true, then there is an entity with this identifier/type combination, but BNet is not
	// yet allowed to show it. Sorry!
	Redacted bool `json:"redacted"`
}