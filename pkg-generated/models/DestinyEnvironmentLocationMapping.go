package bungieAPI

type DestinyEnvironmentLocationMapping struct {

	// The location that is revealed on the director by this mapping.
	LocationHash int `json:"locationHash"`

	// A hint that the UI uses to figure out how this location is activated by the player.
	ActivationSource string `json:"activationSource"`

	// If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don't)
	ItemHash int `json:"itemHash"`

	// If this is populated, this is an objective related to the location.
	ObjectiveHash int `json:"objectiveHash"`

	// If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don't)
	ActivityHash int `json:"activityHash"`
}
