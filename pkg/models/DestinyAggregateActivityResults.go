package bungieapigo

type DestinyAggregateActivityResults struct {

	// List of all activities the player has participated in.
	Activities []DestinyAggregateActivityStats `json:"activities"`
}
