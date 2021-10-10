package bungieAPI

// The base class for any component-returning object that may need to indicate information about
// the state of the component being returned.
type ComponentResponse struct {
	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
