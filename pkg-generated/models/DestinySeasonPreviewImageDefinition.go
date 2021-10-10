package bungieapigo

// Defines the thumbnail icon, high-res image, and video link for promotional images
type DestinySeasonPreviewImageDefinition struct {

    // A thumbnail icon path to preview seasonal content, probably 480x270.
    ThumbnailImage string `json:"thumbnailImage"`


    // An optional path to a high-resolution image, probably 1920x1080.
    HighResImage string `json:"highResImage"`

}

