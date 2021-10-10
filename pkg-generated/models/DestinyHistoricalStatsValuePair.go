package bungieAPI

type DestinyHistoricalStatsValuePair struct {

	// Raw value of the statistic
	Value float64 `json:"value"`

	// Localized formated version of the value.
	DisplayValue string `json:"displayValue"`
}
