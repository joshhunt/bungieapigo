package bungieapigo

type GroupMemberLeaveResult struct {
	Group        GroupV2 `json:"group"`
	GroupDeleted bool    `json:"groupDeleted"`
}
