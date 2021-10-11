package bungieapigo

// Presentation nodes can be restricted by various requirements. This defines the rules of those
// requirements, and the message(s) to be shown if these requirements aren't met.
type DestinyPresentationNodeRequirementsBlock struct {

	// If this node is not accessible due to Entitlements (for instance, you don't own the required
	// game expansion), this is the message to show.
	EntitlementUnavailableMessage string `json:"entitlementUnavailableMessage"`
}
