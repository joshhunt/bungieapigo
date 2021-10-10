package bungieapigo

type SingleComponentResponseOfDestinyItemRenderComponent struct {

    // Many items can be rendered in 3D. When you request this block, you will obtain the custom data
    // needed to render this specific instance of the item.
    Data DestinyItemRenderComponent `json:"data"`

    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

