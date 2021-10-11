package bungieapigo

type DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent struct {
	Data    map[int64]DestinyCurrenciesComponent `json:"data"`
	Privacy ComponentPrivacySetting              `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
