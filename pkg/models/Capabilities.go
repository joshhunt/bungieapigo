package bungieapigo

type Capabilities int

const (
	CapabilitiesNone                  = 0
	CapabilitiesLeaderboards          = 1
	CapabilitiesCallsign              = 2
	CapabilitiesOptionalConversations = 4
	CapabilitiesClanBanner            = 8
	CapabilitiesD2InvestmentData      = 16
	CapabilitiesTags                  = 32
	CapabilitiesAlliances             = 64
)
