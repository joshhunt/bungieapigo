package bungieAPI

// Some items are "sacks" - they can be "opened" to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be "Sacks".
type DestinyItemSackBlockDefinition struct {

	// A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.
	DetailAction string `json:"detailAction"`

	// The localized name of the action being performed when you open the sack.
	OpenAction      string `json:"openAction"`
	SelectItemCount int    `json:"selectItemCount"`
	VendorSackType  string `json:"vendorSackType"`
	OpenOnAcquire   bool   `json:"openOnAcquire"`
}
