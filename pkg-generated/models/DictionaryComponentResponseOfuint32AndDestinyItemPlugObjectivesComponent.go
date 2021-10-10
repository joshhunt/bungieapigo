package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent struct {
    Data map[int]DestinyItemPlugObjectivesComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

