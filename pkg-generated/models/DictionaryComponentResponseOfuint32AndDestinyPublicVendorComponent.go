package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent struct {
    Data map[int]DestinyPublicVendorComponent `json:"data"`
    Privacy ComponentPrivacySetting `json:"privacy"`

    // If true, this component is disabled.
    Disabled bool `json:"disabled"`

}

