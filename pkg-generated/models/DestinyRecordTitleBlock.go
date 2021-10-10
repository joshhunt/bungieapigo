package bungieAPI

type DestinyRecordTitleBlock struct {
	HasTitle       bool                     `json:"hasTitle"`
	TitlesByGender map[DestinyGender]string `json:"titlesByGender"`

	// For those who prefer to use the definitions.
	TitlesByGenderHash map[int]string `json:"titlesByGenderHash"`

	GildingTrackingRecordHash int `json:"gildingTrackingRecordHash"`
}
