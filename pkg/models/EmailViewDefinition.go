package bungieapigo

// Represents a data-driven view for Email settings. Web/Mobile UI can use this data to show new
// EMail settings consistently without further manual work.
type EmailViewDefinition struct {

	// The identifier for this view.
	Name string `json:"name"`

	// The ordered list of settings to show in this view.
	ViewSettings []EmailViewDefinitionSetting `json:"viewSettings"`
}
