package bungieAPI

type GroupPotentialMembership struct {
	Member GroupPotentialMember `json:"member"`
	Group  GroupV2              `json:"group"`
}
