package bungieapigo

type SingleComponentResponseOfDestinyItemObjectivesComponent struct {

    // Items can have objectives and progression. When you request this block, you will obtain
    // information about any Objectives and progression tied to this item.
    Data DestinyItemObjectivesComponent `json:"data"`

    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

