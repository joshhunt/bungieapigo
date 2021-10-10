package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent struct {
    Data map[int64]DestinyPresentationNodesComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

