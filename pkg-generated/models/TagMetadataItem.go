package bungieapigo

type TagMetadataItem struct {
    Description string `json:"description"`
    TagText string `json:"tagText"`
    Groups []string `json:"groups"`
    IsDefault bool `json:"isDefault"`
    Name string `json:"name"`
}

