package bungieapigo

type SingleComponentResponseOfDestinyCharacterRecordsComponent struct {
    Data DestinyCharacterRecordsComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

