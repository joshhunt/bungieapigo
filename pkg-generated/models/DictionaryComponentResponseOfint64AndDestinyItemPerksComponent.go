package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemPerksComponent struct {
    Data map[int64]DestinyItemPerksComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

