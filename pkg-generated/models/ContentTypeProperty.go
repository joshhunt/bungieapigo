package bungieAPI

type ContentTypeProperty struct {
	Name                           string                      `json:"name"`
	RootPropertyName               string                      `json:"rootPropertyName"`
	ReadableName                   string                      `json:"readableName"`
	Value                          string                      `json:"value"`
	PropertyDescription            string                      `json:"propertyDescription"`
	Localizable                    bool                        `json:"localizable"`
	Fallback                       bool                        `json:"fallback"`
	Enabled                        bool                        `json:"enabled"`
	Order                          int                         `json:"order"`
	Visible                        bool                        `json:"visible"`
	IsTitle                        bool                        `json:"isTitle"`
	Required                       bool                        `json:"required"`
	MaxLength                      int                         `json:"maxLength"`
	MaxByteLength                  int                         `json:"maxByteLength"`
	MaxFileSize                    int                         `json:"maxFileSize"`
	Regexp                         string                      `json:"regexp"`
	ValidateAs                     string                      `json:"validateAs"`
	RssAttribute                   string                      `json:"rssAttribute"`
	VisibleDependency              string                      `json:"visibleDependency"`
	VisibleOn                      string                      `json:"visibleOn"`
	Datatype                       ContentPropertyDataTypeEnum `json:"datatype"`
	Attributes                     map[string]string           `json:"attributes"`
	ChildProperties                []ContentTypeProperty       `json:"childProperties"`
	ContentTypeAllowed             string                      `json:"contentTypeAllowed"`
	BindToProperty                 string                      `json:"bindToProperty"`
	BoundRegex                     string                      `json:"boundRegex"`
	RepresentationSelection        map[string]string           `json:"representationSelection"`
	DefaultValues                  []ContentTypeDefaultValue   `json:"defaultValues"`
	IsExternalAllowed              bool                        `json:"isExternalAllowed"`
	PropertySection                string                      `json:"propertySection"`
	Weight                         int                         `json:"weight"`
	Entitytype                     string                      `json:"entitytype"`
	IsCombo                        bool                        `json:"isCombo"`
	SuppressProperty               bool                        `json:"suppressProperty"`
	LegalContentTypes              []string                    `json:"legalContentTypes"`
	RepresentationValidationString string                      `json:"representationValidationString"`
	MinWidth                       int                         `json:"minWidth"`
	MaxWidth                       int                         `json:"maxWidth"`
	MinHeight                      int                         `json:"minHeight"`
	MaxHeight                      int                         `json:"maxHeight"`
	IsVideo                        bool                        `json:"isVideo"`
	IsImage                        bool                        `json:"isImage"`
}
