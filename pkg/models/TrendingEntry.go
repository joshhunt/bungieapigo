package bungieapigo

import "time"

// The list entry view for trending items. Returns just enough to show the item on the trending
// page.
type TrendingEntry struct {

	// The weighted score of this trending item.
	Weight float64 `json:"weight"`

	IsFeatured bool `json:"isFeatured"`

	// We don't know whether the identifier will be a string, a uint, or a long... so we're going to cast
	// it all to a string. But either way, we need any trending item created to have a single unique
	// identifier for its type.
	Identifier string `json:"identifier"`

	// An enum - unfortunately - dictating all of the possible kinds of trending items that you might
	// get in your result set, in case you want to do custom rendering or call to get the details of the
	// item.
	EntityType TrendingEntryType `json:"entityType"`

	// The localized "display name/article title/'primary localized identifier'" of the entity.
	DisplayName string `json:"displayName"`

	// If the entity has a localized tagline/subtitle/motto/whatever, that is found here.
	Tagline string `json:"tagline"`

	Image     string    `json:"image"`
	StartDate time.Time `json:"startDate"`
	EndDate   time.Time `json:"endDate"`
	Link      string    `json:"link"`

	// If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to
	// regret putting this directly on TrendingEntry, but it will work so yolo
	WebmVideo string `json:"webmVideo"`

	// If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to
	// regret putting this directly on TrendingEntry, but it will work so yolo
	Mp4Video string `json:"mp4Video"`

	// If isFeatured, this image will be populated with whatever the featured image is. Note that this
	// will likely be a very large image, so don't use it all the time.
	FeatureImage string `json:"featureImage"`

	// If the item is of entityType TrendingEntryType.Container, it may have items - also Trending
	// Entries - contained within it. This is the ordered list of those to display under the
	// Container's header.
	Items []TrendingEntry `json:"items"`

	// If the entry has a date at which it was created, this is that date.
	CreationDate time.Time `json:"creationDate"`
}
