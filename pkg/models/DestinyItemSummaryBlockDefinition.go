package bungieapigo

// This appears to be information used when rendering rewards. We don't currently use it on BNet.
type DestinyItemSummaryBlockDefinition struct {

	// Apparently when rendering an item in a reward, this should be used as a sort priority. We're not
	// doing it presently.
	SortPriority int `json:"sortPriority"`
}
