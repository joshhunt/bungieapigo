package bungieAPI

// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
type DestinyProfileTransitoryJoinability struct {

	// The number of slots still available on this person's fireteam.
	OpenSlots int `json:"openSlots"`

	// Who the person is currently allowing invites from.
	PrivacySetting DestinyGamePrivacySetting `json:"privacySetting"`

	// Reasons why a person can't join this person's fireteam.
	ClosedReasons DestinyJoinClosedReasons `json:"closedReasons"`
}
