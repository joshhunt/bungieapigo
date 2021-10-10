package bungieAPI

import "time"

type GroupV2 struct {
	GroupId                            int64               `json:"groupId"`
	Name                               string              `json:"name"`
	GroupType                          GroupType           `json:"groupType"`
	MembershipIdCreated                int64               `json:"membershipIdCreated"`
	CreationDate                       time.Time           `json:"creationDate"`
	ModificationDate                   time.Time           `json:"modificationDate"`
	About                              string              `json:"about"`
	Tags                               []string            `json:"tags"`
	MemberCount                        int                 `json:"memberCount"`
	IsPublic                           bool                `json:"isPublic"`
	IsPublicTopicAdminOnly             bool                `json:"isPublicTopicAdminOnly"`
	Motto                              string              `json:"motto"`
	AllowChat                          bool                `json:"allowChat"`
	IsDefaultPostPublic                bool                `json:"isDefaultPostPublic"`
	ChatSecurity                       ChatSecuritySetting `json:"chatSecurity"`
	Locale                             string              `json:"locale"`
	AvatarImageIndex                   int                 `json:"avatarImageIndex"`
	Homepage                           GroupHomepage       `json:"homepage"`
	MembershipOption                   MembershipOption    `json:"membershipOption"`
	DefaultPublicity                   GroupPostPublicity  `json:"defaultPublicity"`
	Theme                              string              `json:"theme"`
	BannerPath                         string              `json:"bannerPath"`
	AvatarPath                         string              `json:"avatarPath"`
	ConversationId                     int64               `json:"conversationId"`
	EnableInvitationMessagingForAdmins bool                `json:"enableInvitationMessagingForAdmins"`
	BanExpireDate                      time.Time           `json:"banExpireDate"`
	Features                           GroupFeatures       `json:"features"`

	// The same as GroupV2ClanInfo, but includes any investment data.
	ClanInfo GroupV2ClanInfoAndInvestment `json:"clanInfo"`
}
