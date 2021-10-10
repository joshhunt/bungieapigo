package bungieapigo

type SingleComponentResponseOfDestinyCollectiblesComponent struct {
    Data DestinyCollectiblesComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

