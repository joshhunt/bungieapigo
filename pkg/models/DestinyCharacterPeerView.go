package bungieapigo

// A minimal view of a character's equipped items, for the purpose of rendering a summary screen or
// showing the character in 3D.
type DestinyCharacterPeerView struct {
	Equipment []DestinyItemPeerView `json:"equipment"`
}
