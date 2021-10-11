package bungieapigo

type GroupEditAction struct {
	Name                               string `json:"name"`
	About                              string `json:"about"`
	Motto                              string `json:"motto"`
	Theme                              string `json:"theme"`
	AvatarImageIndex                   int    `json:"avatarImageIndex"`
	Tags                               string `json:"tags"`
	IsPublic                           bool   `json:"isPublic"`
	MembershipOption                   int    `json:"membershipOption"`
	IsPublicTopicAdminOnly             bool   `json:"isPublicTopicAdminOnly"`
	AllowChat                          bool   `json:"allowChat"`
	ChatSecurity                       int    `json:"chatSecurity"`
	Callsign                           string `json:"callsign"`
	Locale                             string `json:"locale"`
	Homepage                           int    `json:"homepage"`
	EnableInvitationMessagingForAdmins bool   `json:"enableInvitationMessagingForAdmins"`
	DefaultPublicity                   int    `json:"defaultPublicity"`
}
