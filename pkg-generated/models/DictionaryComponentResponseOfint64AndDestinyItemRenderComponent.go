package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemRenderComponent struct {
    Data map[int64]DestinyItemRenderComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

