package bungieapigo

// A hint for what screen should be shown when this presentation node is clicked into. How you use
// this is your UI is up to you.
type DestinyPresentationScreenStyle int

const (

	// Use the "default" view for the presentation nodes.
	DestinyPresentationScreenStyleDefault = 0

	// Show sub-items as "category sets". In-game, you'd see these as a vertical list of child
	// presentation nodes - armor sets for example - and the icons of items within those sets displayed
	// horizontally.
	DestinyPresentationScreenStyleCategorySets = 1

	// Show sub-items as Badges. (I know, I know. We don't need no stinkin' badges har har har)
	DestinyPresentationScreenStyleBadge = 2
)
