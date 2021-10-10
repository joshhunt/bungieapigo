package bungieAPI

// These definitions represent faction vendors at different points in the game.
// A single faction may contain multiple vendors, or the same vendor available at two different locations.
type DestinyFactionVendorDefinition struct {

	// The faction vendor hash.
	VendorHash int `json:"vendorHash"`

	// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
	DestinationHash int `json:"destinationHash"`

	// The relative path to the background image representing this Vendor at this location, for use in a banner.
	BackgroundImagePath string `json:"backgroundImagePath"`
}
