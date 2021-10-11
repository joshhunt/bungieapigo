package bungieapigo

type GroupMemberCountFilter int

const (
	GroupMemberCountFilterAll                   = 0
	GroupMemberCountFilterOneToTen              = 1
	GroupMemberCountFilterElevenToOneHundred    = 2
	GroupMemberCountFilterGreaterThanOneHundred = 3
)
