package bungieAPI

type DestinyObjectiveDisplayProperties struct {

	// The activity associated with this objective in the context of this item, if any.
	ActivityHash int `json:"activityHash"`

	// If true, the game shows this objective on item preview screens.
	DisplayOnItemPreviewScreen bool `json:"displayOnItemPreviewScreen"`
}
