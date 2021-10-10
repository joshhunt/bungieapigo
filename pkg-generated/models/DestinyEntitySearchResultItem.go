package bungieAPI

// An individual Destiny Entity returned from the entity search.
type DestinyEntitySearchResultItem struct {

	// The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.
	Hash int `json:"hash"`

	// The type of entity, returned as a string matching the DestinyDefinition's contract class name. You'll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.
	EntityType string `json:"entityType"`

	// Basic display properties on the entity, so you don't have to look up the definition to show basic results for the item.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.
	Weight float64 `json:"weight"`
}
