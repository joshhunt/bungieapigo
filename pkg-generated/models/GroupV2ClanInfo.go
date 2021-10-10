package bungieAPI

// This contract contains clan-specific group information. It does not include any investment data.
type GroupV2ClanInfo struct {
	ClanCallsign   string     `json:"clanCallsign"`
	ClanBannerData ClanBanner `json:"clanBannerData"`
}
