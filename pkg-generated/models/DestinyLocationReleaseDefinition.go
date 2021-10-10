package bungieapigo

// A specific "spot" referred to by a location. Only one of these can be active at a time for a given
// Location.
type DestinyLocationReleaseDefinition struct {

    // Sadly, these don't appear to be populated anymore (ever?)
    DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

    SmallTransparentIcon string `json:"smallTransparentIcon"`
    MapIcon string `json:"mapIcon"`
    LargeTransparentIcon string `json:"largeTransparentIcon"`

    // If we had map information, this spawnPoint would be interesting. But sadly, we don't have that
    // info.
    SpawnPoint int `json:"spawnPoint"`


    // The Destination being pointed to by this location.
    DestinationHash int `json:"destinationHash"`


    // The Activity being pointed to by this location.
    ActivityHash int `json:"activityHash"`


    // The Activity Graph being pointed to by this location.
    ActivityGraphHash int `json:"activityGraphHash"`


    // The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node
    // hashes are only unique within an Activity Graph: so use the combination to find the node being
    // spoken of)
    ActivityGraphNodeHash int `json:"activityGraphNodeHash"`


    // The Activity Bubble within the Destination. Look this up in the
    // DestinyDestinationDefinition's bubbles and bubbleSettings properties.
    ActivityBubbleName int `json:"activityBubbleName"`


    // If we had map information, this would tell us something cool about the path this location wants
    // you to take. I wish we had map information.
    ActivityPathBundle int `json:"activityPathBundle"`


    // If we had map information, this would tell us about path information related to destination on
    // the map. Sad. Maybe you can do something cool with it. Go to town man.
    ActivityPathDestination int `json:"activityPathDestination"`


    // The type of Nav Point that this represents. See the enumeration for more info.
    NavPointType DestinyActivityNavPointType `json:"navPointType"`


    // Looks like it should be the position on the map, but sadly it does not look populated... yet?
    WorldPosition []int `json:"worldPosition"`

}

