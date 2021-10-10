package bungieAPI

// The member levels used by all V2 Groups API. Individual group types use their own mappings in their native storage (general uses BnetDbGroupMemberType and D2 clans use ClanMemberLevel), but they are all translated to this in the runtime api. These runtime values should NEVER be stored anywhere, so the values can be changed as necessary.
type RuntimeGroupMemberType int

const (
	RuntimeGroupMemberTypeNone          = 0
	RuntimeGroupMemberTypeBeginner      = 1
	RuntimeGroupMemberTypeMember        = 2
	RuntimeGroupMemberTypeAdmin         = 3
	RuntimeGroupMemberTypeActingFounder = 4
	RuntimeGroupMemberTypeFounder       = 5
)
