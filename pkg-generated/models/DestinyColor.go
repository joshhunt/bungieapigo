package bungieapigo

// Represents a color whose RGBA values are all represented as values between 0 and 255.
type DestinyColor struct {
    Red int `json:"red"`
    Green int `json:"green"`
    Blue int `json:"blue"`
    Alpha int `json:"alpha"`
}

