package bungieapigo

type SingleComponentResponseOfDestinyItemPlugObjectivesComponent struct {
    Data DestinyItemPlugObjectivesComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

