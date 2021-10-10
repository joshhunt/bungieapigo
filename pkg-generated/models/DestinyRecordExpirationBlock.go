package bungieapigo

// If this record has an expiration after which it cannot be earned, this is some information about
// that expiration.
type DestinyRecordExpirationBlock struct {
    HasExpiration bool `json:"hasExpiration"`
    Description string `json:"description"`
    Icon string `json:"icon"`
}

