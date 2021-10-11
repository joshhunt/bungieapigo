package bungieapigo

type TagMetadataDefinition struct {
	Description string            `json:"description"`
	Order       int               `json:"order"`
	Items       []TagMetadataItem `json:"items"`
	Datatype    string            `json:"datatype"`
	Name        string            `json:"name"`
	IsRequired  bool              `json:"isRequired"`
}
