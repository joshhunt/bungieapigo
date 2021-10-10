package bungieapigo

type DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent struct {
    Data map[int]DestinyItemSocketsComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

