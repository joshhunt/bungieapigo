package bungieAPI

type CoreSettingsConfiguration struct {
	Environment                    string                `json:"environment"`
	Systems                        map[string]CoreSystem `json:"systems"`
	IgnoreReasons                  []CoreSetting         `json:"ignoreReasons"`
	ForumCategories                []CoreSetting         `json:"forumCategories"`
	GroupAvatars                   []CoreSetting         `json:"groupAvatars"`
	DestinyMembershipTypes         []CoreSetting         `json:"destinyMembershipTypes"`
	RecruitmentPlatformTags        []CoreSetting         `json:"recruitmentPlatformTags"`
	RecruitmentMiscTags            []CoreSetting         `json:"recruitmentMiscTags"`
	RecruitmentActivities          []CoreSetting         `json:"recruitmentActivities"`
	UserContentLocales             []CoreSetting         `json:"userContentLocales"`
	SystemContentLocales           []CoreSetting         `json:"systemContentLocales"`
	ClanBannerDecals               []CoreSetting         `json:"clanBannerDecals"`
	ClanBannerDecalColors          []CoreSetting         `json:"clanBannerDecalColors"`
	ClanBannerGonfalons            []CoreSetting         `json:"clanBannerGonfalons"`
	ClanBannerGonfalonColors       []CoreSetting         `json:"clanBannerGonfalonColors"`
	ClanBannerGonfalonDetails      []CoreSetting         `json:"clanBannerGonfalonDetails"`
	ClanBannerGonfalonDetailColors []CoreSetting         `json:"clanBannerGonfalonDetailColors"`
	ClanBannerStandards            []CoreSetting         `json:"clanBannerStandards"`
	Destiny2CoreSettings           Destiny2CoreSettings  `json:"destiny2CoreSettings"`

	// The set of all email subscription/opt-in settings and definitions.
	EmailSettings      EmailSettings `json:"emailSettings"`
	FireteamActivities []CoreSetting `json:"fireteamActivities"`
}
