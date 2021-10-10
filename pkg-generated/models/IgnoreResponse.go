package bungieapigo

type IgnoreResponse struct {
    IsIgnored bool `json:"isIgnored"`
    IgnoreFlags IgnoreStatus `json:"ignoreFlags"`
}

