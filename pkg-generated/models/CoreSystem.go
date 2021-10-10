package bungieAPI

type CoreSystem struct {
	Enabled    bool              `json:"enabled"`
	Parameters map[string]string `json:"parameters"`
}
