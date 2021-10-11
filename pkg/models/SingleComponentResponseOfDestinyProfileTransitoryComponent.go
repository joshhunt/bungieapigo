package bungieapigo

type SingleComponentResponseOfDestinyProfileTransitoryComponent struct {

	// This is an experimental set of data that Bungie considers to be "transitory" - information that
	// may be useful for API users, but that is coming from a non-authoritative data source about
	// information that could potentially change at a more frequent pace than Bungie.net will
	// receive updates about it.
	// This information is provided exclusively for convenience should any of it be useful to users:
	// we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know
	// that this data can potentially be out-of-date or even wrong entirely if the user disconnected
	// from the game or suddenly changed their status before we can receive refreshed data.
	Data DestinyProfileTransitoryComponent `json:"data"`

	Privacy ComponentPrivacySetting `json:"privacy"`

	// If true, this component is disabled.
	Disabled bool `json:"disabled"`
}
