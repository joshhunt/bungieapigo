package bungieapigo

type CoreSetting struct {
	Identifier    string        `json:"identifier"`
	IsDefault     bool          `json:"isDefault"`
	DisplayName   string        `json:"displayName"`
	Summary       string        `json:"summary"`
	ImagePath     string        `json:"imagePath"`
	ChildSettings []CoreSetting `json:"childSettings"`
}
