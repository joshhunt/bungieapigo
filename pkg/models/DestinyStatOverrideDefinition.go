package bungieapigo

// Stat Groups (DestinyStatGroupDefinition) has the ability to override the localized text
// associated with stats that are to be shown on the items with which they are associated.
// This defines a specific overridden stat. You could theoretically check these before
// rendering your stat UI, and for each stat that has an override show these displayProperties
// instead of those on the DestinyStatDefinition.
// Or you could be like us, and skip that for now because the game has yet to actually use this
// feature. But know that it's here, waiting for a resilliant young designer to take up the mantle
// and make us all look foolish by showing the wrong name for stats.
// Note that, if this gets used, the override will apply only to items using the overriding Stat
// Group. Other items will still show the default stat's name/description.
type DestinyStatOverrideDefinition struct {

	// The hash identifier of the stat whose display properties are being overridden.
	StatHash int `json:"statHash"`

	// The display properties to show instead of the base DestinyStatDefinition display
	// properties.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`
}
