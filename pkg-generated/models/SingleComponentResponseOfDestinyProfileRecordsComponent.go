package bungieapigo

type SingleComponentResponseOfDestinyProfileRecordsComponent struct {
    Data DestinyProfileRecordsComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

