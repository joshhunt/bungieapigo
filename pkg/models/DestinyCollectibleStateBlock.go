package bungieapigo

type DestinyCollectibleStateBlock struct {
	ObscuredOverrideItemHash int `json:"obscuredOverrideItemHash"`

	// Presentation nodes can be restricted by various requirements. This defines the rules of those
	// requirements, and the message(s) to be shown if these requirements aren't met.
	Requirements DestinyPresentationNodeRequirementsBlock `json:"requirements"`
}
