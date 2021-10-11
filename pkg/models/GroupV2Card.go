package bungieapigo

import "time"

// A small infocard of group information, usually used for when a list of groups are returned
type GroupV2Card struct {
	GroupId          int64            `json:"groupId"`
	Name             string           `json:"name"`
	GroupType        GroupType        `json:"groupType"`
	CreationDate     time.Time        `json:"creationDate"`
	About            string           `json:"about"`
	Motto            string           `json:"motto"`
	MemberCount      int              `json:"memberCount"`
	Locale           string           `json:"locale"`
	MembershipOption MembershipOption `json:"membershipOption"`
	Capabilities     Capabilities     `json:"capabilities"`

	// This contract contains clan-specific group information. It does not include any investment
	// data.
	ClanInfo GroupV2ClanInfo `json:"clanInfo"`

	AvatarPath string `json:"avatarPath"`
	Theme      string `json:"theme"`
}
