package bungieAPI

import "time"

type ContentItemPublicContract struct {
	ContentId                   int64       `json:"contentId"`
	CType                       string      `json:"cType"`
	CmsPath                     string      `json:"cmsPath"`
	CreationDate                time.Time   `json:"creationDate"`
	ModifyDate                  time.Time   `json:"modifyDate"`
	AllowComments               bool        `json:"allowComments"`
	HasAgeGate                  bool        `json:"hasAgeGate"`
	MinimumAge                  int         `json:"minimumAge"`
	RatingImagePath             string      `json:"ratingImagePath"`
	Author                      GeneralUser `json:"author"`
	AutoEnglishPropertyFallback bool        `json:"autoEnglishPropertyFallback"`

	// Firehose content is really a collection of metadata and "properties", which are the
	// potentially-but-not-strictly localizable data that comprises the meat of whatever content
	// is being shown.
	// As Cole Porter would have crooned, "Anything Goes" with Firehose properties. They are most
	// often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON
	// structures, simple strings, numbers etc... The Content Type of the item (cType) will describe
	// the properties, and thus how they ought to be deserialized.
	Properties map[string]map[string]string `json:"properties"`

	Representations []ContentRepresentation `json:"representations"`

	// NOTE: Tags will always be lower case.
	Tags []string `json:"tags"`

	CommentSummary CommentSummary `json:"commentSummary"`
}
