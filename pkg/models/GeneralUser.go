package bungieapigo

import "time"

type GeneralUser struct {
	MembershipId                      int64             `json:"membershipId"`
	UniqueName                        string            `json:"uniqueName"`
	NormalizedName                    string            `json:"normalizedName"`
	DisplayName                       string            `json:"displayName"`
	ProfilePicture                    int               `json:"profilePicture"`
	ProfileTheme                      int               `json:"profileTheme"`
	UserTitle                         int               `json:"userTitle"`
	SuccessMessageFlags               int64             `json:"successMessageFlags"`
	IsDeleted                         bool              `json:"isDeleted"`
	About                             string            `json:"about"`
	FirstAccess                       time.Time         `json:"firstAccess"`
	LastUpdate                        time.Time         `json:"lastUpdate"`
	LegacyPortalUid                   int64             `json:"legacyPortalUID"`
	Context                           UserToUserContext `json:"context"`
	PsnDisplayName                    string            `json:"psnDisplayName"`
	XboxDisplayName                   string            `json:"xboxDisplayName"`
	FbDisplayName                     string            `json:"fbDisplayName"`
	ShowActivity                      bool              `json:"showActivity"`
	Locale                            string            `json:"locale"`
	LocaleInheritDefault              bool              `json:"localeInheritDefault"`
	LastBanReportId                   int64             `json:"lastBanReportId"`
	ShowGroupMessaging                bool              `json:"showGroupMessaging"`
	ProfilePicturePath                string            `json:"profilePicturePath"`
	ProfilePictureWidePath            string            `json:"profilePictureWidePath"`
	ProfileThemeName                  string            `json:"profileThemeName"`
	UserTitleDisplay                  string            `json:"userTitleDisplay"`
	StatusText                        string            `json:"statusText"`
	StatusDate                        time.Time         `json:"statusDate"`
	ProfileBanExpire                  time.Time         `json:"profileBanExpire"`
	BlizzardDisplayName               string            `json:"blizzardDisplayName"`
	SteamDisplayName                  string            `json:"steamDisplayName"`
	StadiaDisplayName                 string            `json:"stadiaDisplayName"`
	TwitchDisplayName                 string            `json:"twitchDisplayName"`
	CachedBungieGlobalDisplayName     string            `json:"cachedBungieGlobalDisplayName"`
	CachedBungieGlobalDisplayNameCode int               `json:"cachedBungieGlobalDisplayNameCode"`
}
