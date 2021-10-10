package bungieapigo

// The same as GroupV2ClanInfo, but includes any investment data.
type GroupV2ClanInfoAndInvestment struct {
    D2ClanProgressions map[int]DestinyProgression `json:"d2ClanProgressions"`
    ClanCallsign string `json:"clanCallsign"`
    ClanBannerData ClanBanner `json:"clanBannerData"`
}

