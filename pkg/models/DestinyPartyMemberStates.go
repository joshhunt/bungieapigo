package bungieapigo

// A flags enumeration that represents a Fireteam Member's status.
type DestinyPartyMemberStates int

const (
	DestinyPartyMemberStatesNone = 0

	// This one's pretty obvious - they're on your Fireteam.
	DestinyPartyMemberStatesFireteamMember = 1

	// I don't know what it means to be in a 'Posse', but apparently this is it.
	DestinyPartyMemberStatesPosseMember = 2

	// Nor do I understand the difference between them being in a 'Group' vs. a 'Fireteam'.
	// I'll update these docs once I get more info. If I get more info. If you're reading this, I never got
	// more info. You're on your own, kid.
	DestinyPartyMemberStatesGroupMember = 4

	// This person is the party leader.
	DestinyPartyMemberStatesPartyLeader = 8
)
