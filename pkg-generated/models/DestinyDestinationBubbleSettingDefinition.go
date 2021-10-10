package bungieAPI

// Human readable data about the bubble. Combine with DestinyBubbleDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.
// DEPRECATED - Just use bubbles.
type DestinyDestinationBubbleSettingDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`
}
