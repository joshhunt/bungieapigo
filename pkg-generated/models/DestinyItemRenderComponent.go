package bungieAPI

// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
type DestinyItemRenderComponent struct {

	// If you should use custom dyes on this item, it will be indicated here.
	UseCustomDyes bool `json:"useCustomDyes"`

	// A dictionary for rendering gear components, with:
	// key = Art Arrangement Region Index
	// value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.
	ArtRegions map[int]int `json:"artRegions"`
}
