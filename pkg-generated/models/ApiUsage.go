package bungieAPI

type ApiUsage struct {

	// Counts for on API calls made for the time range.
	ApiCalls []Series `json:"apiCalls"`

	// Instances of blocked requests or requests that crossed the warn threshold during the time range.
	ThrottledRequests []Series `json:"throttledRequests"`
}
