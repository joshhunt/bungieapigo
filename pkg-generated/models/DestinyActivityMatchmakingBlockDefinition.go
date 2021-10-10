package bungieAPI

// Information about matchmaking and party size for the activity.
type DestinyActivityMatchmakingBlockDefinition struct {

	// If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.
	IsMatchmade bool `json:"isMatchmade"`

	// The minimum # of people in the fireteam for the activity to launch.
	MinParty int `json:"minParty"`

	// The maximum # of people allowed in a Fireteam.
	MaxParty int `json:"maxParty"`

	// The maximum # of people allowed across all teams in the activity.
	MaxPlayers int `json:"maxPlayers"`

	// If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.
	RequiresGuardianOath bool `json:"requiresGuardianOath"`
}
