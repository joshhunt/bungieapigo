package bungieAPI

// A hint for how the presentation node should be displayed when shown in a list. How you use this is
// your UI is up to you.
type DestinyPresentationDisplayStyle int

const (

	// Display the item as a category, through which sub-items are filtered.
	DestinyPresentationDisplayStyleCategory = 0

	DestinyPresentationDisplayStyleBadge       = 1
	DestinyPresentationDisplayStyleMedals      = 2
	DestinyPresentationDisplayStyleCollectible = 3
	DestinyPresentationDisplayStyleRecord      = 4
)
