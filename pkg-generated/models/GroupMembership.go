package bungieAPI

type GroupMembership struct {
	Member GroupMember `json:"member"`
	Group  GroupV2     `json:"group"`
}
