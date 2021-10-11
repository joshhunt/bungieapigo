package bungieapigo

// Represents a specific group of vendors that can be rendered in the recommended order.
// How do we figure out this order? It's a long story, and will likely get more complicated over
// time.
type DestinyVendorGroup struct {
	VendorGroupHash int `json:"vendorGroupHash"`

	// The ordered list of vendors within a particular group.
	VendorHashes []int `json:"vendorHashes"`
}
