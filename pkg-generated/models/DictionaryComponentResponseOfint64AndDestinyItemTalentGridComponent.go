package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent struct {
    Data map[int64]DestinyItemTalentGridComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

