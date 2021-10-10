package bungieapigo

type SingleComponentResponseOfDestinyCharacterRenderComponent struct {

    // Only really useful if you're attempting to render the character's current appearance in 3D,
    // this returns a bare minimum of information, pre-aggregated, that you'll need to perform that
    // rendering. Note that you need to combine this with other 3D assets and data from our servers.
    // Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use
    // this data, but be warned: the rabbit hole goes pretty deep.
    Data DestinyCharacterRenderComponent `json:"data"`

    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

