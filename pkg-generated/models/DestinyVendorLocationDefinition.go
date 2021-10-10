package bungieAPI

// These definitions represent vendors' locations and relevant display information at
// different times in the game.
type DestinyVendorLocationDefinition struct {

	// The hash identifier for a Destination at which this vendor may be located. Each destination
	// where a Vendor may exist will only ever have a single entry.
	DestinationHash int `json:"destinationHash"`

	// The relative path to the background image representing this Vendor at this location, for use in
	// a banner.
	BackgroundImagePath string `json:"backgroundImagePath"`
}
