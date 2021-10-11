package bungieapigo

type DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent struct {
	Data    map[int]DestinyItemTalentGridComponent `json:"data"`
	Privacy ComponentPrivacySetting                `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
