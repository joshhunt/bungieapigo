package bungieAPI

type Series struct {

	// Collection of samples with time and value.
	Datapoints []Datapoint `json:"datapoints"`

	// Target to which to datapoints apply.
	Target string `json:"target"`
}
