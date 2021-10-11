package bungieapigo

// An artificial construct provided by Bungie.Net, where we attempt to group talent nodes by
// functionality.
// This is a single set of references to Talent Nodes that share a common trait or purpose.
type DestinyTalentNodeCategory struct {

	// Mostly just for debug purposes, but if you find it useful you can have it. This is BNet's manually
	// created identifier for this category.
	Identifier string `json:"identifier"`

	// If true, we found the localized content in a related DestinyLoreDefinition instead of local
	// BNet localization files. This is mostly for ease of my own future investigations.
	IsLoreDriven bool `json:"isLoreDriven"`

	// Will contain at least the "name", which will be the title of the category. We will likely not have
	// description and an icon yet, but I'm going to keep my options open.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this
	// Talent Grid that are part of this Category.
	NodeHashes []int `json:"nodeHashes"`
}
