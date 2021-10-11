package bungieapigo

type ContentTypeDescription struct {
	CType                       string                       `json:"cType"`
	Name                        string                       `json:"name"`
	ContentDescription          string                       `json:"contentDescription"`
	PreviewImage                string                       `json:"previewImage"`
	Priority                    int                          `json:"priority"`
	Reminder                    string                       `json:"reminder"`
	Properties                  []ContentTypeProperty        `json:"properties"`
	TagMetadata                 []TagMetadataDefinition      `json:"tagMetadata"`
	TagMetadataItems            map[string]TagMetadataItem   `json:"tagMetadataItems"`
	UsageExamples               []string                     `json:"usageExamples"`
	ShowInContentEditor         bool                         `json:"showInContentEditor"`
	TypeOf                      string                       `json:"typeOf"`
	BindIdentifierToProperty    string                       `json:"bindIdentifierToProperty"`
	BoundRegex                  string                       `json:"boundRegex"`
	ForceIdentifierBinding      bool                         `json:"forceIdentifierBinding"`
	AllowComments               bool                         `json:"allowComments"`
	AutoEnglishPropertyFallback bool                         `json:"autoEnglishPropertyFallback"`
	BulkUploadable              bool                         `json:"bulkUploadable"`
	Previews                    []ContentPreview             `json:"previews"`
	SuppressCmsPath             bool                         `json:"suppressCmsPath"`
	PropertySections            []ContentTypePropertySection `json:"propertySections"`
}
