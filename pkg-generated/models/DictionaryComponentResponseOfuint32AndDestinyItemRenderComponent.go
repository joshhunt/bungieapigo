package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent struct {
    Data map[int]DestinyItemRenderComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

