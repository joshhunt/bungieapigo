package bungieapigo

// Basic identifying data about the bubble. Combine with
// DestinyDestinationBubbleSettingDefinition - see
// DestinyDestinationDefinition.bubbleSettings for more information.
type DestinyBubbleDefinition struct {

	// The identifier for the bubble: only guaranteed to be unique within the Destination.
	Hash int `json:"hash"`

	// The display properties of this bubble, so you don't have to look them up in a separate list
	// anymore.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`
}
