package bungieapigo

// Defines the promotional text, images, and links to preview this season.
type DestinySeasonPreviewDefinition struct {

	// A localized description of the season.
	Description string `json:"description"`

	// A relative path to learn more about the season. Web browsers should be automatically
	// redirected to the user's Bungie.net locale. For example: "/SeasonOfTheChosen" will
	// redirect to "/7/en/Seasons/SeasonOfTheChosen" for English users.
	LinkPath string `json:"linkPath"`

	// An optional link to a localized video, probably YouTube.
	VideoLink string `json:"videoLink"`

	// A list of images to preview the seasonal content. Should have at least three to show.
	Images []DestinySeasonPreviewImageDefinition `json:"images"`
}
