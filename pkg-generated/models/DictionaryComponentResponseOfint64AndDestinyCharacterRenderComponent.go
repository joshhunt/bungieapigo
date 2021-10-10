package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent struct {
    Data map[int64]DestinyCharacterRenderComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

