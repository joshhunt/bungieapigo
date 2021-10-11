package bungieapigo

type ImagePyramidEntry struct {

	// The name of the subfolder where these images are located.
	Name string `json:"name"`

	// The factor by which the original image size has been reduced.
	Factor float64 `json:"factor"`
}
