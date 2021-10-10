package bungieAPI

// The properties of an individual checklist item. Note that almost everything is optional: it is *highly* variable what kind of data we'll actually be able to return: at times we may have no other relationships to entities at all.
// Whatever UI you build, do it with the knowledge that any given entry might not actually be able to be associated with some other Destiny entity.
type DestinyChecklistEntryDefinition struct {

	// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
	Hash int `json:"hash"`

	// Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`
	DestinationHash   int                                `json:"destinationHash"`
	LocationHash      int                                `json:"locationHash"`

	// Note that a Bubble's hash doesn't uniquely identify a "top level" entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.
	// You can use this property if it is populated to look up the DestinyLocationDefinition's associated .locationReleases[].activityBubbleName property.
	BubbleHash             int `json:"bubbleHash"`
	ActivityHash           int `json:"activityHash"`
	ItemHash               int `json:"itemHash"`
	VendorHash             int `json:"vendorHash"`
	VendorInteractionIndex int `json:"vendorInteractionIndex"`

	// The scope at which this specific entry can be computed.
	Scope DestinyScope `json:"scope"`
}
