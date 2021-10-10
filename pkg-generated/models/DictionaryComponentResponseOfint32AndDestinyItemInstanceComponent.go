package bungieapigo

type DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent struct {
    Data map[int]DestinyItemInstanceComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

