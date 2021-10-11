package bungieapigo

type DestinyPlayer struct {

	// Details about the player as they are known in game (platform display name, Destiny emblem)
	DestinyUserInfo UserInfoCard `json:"destinyUserInfo"`

	// Class of the character if applicable and available.
	CharacterClass string `json:"characterClass"`

	ClassHash  int `json:"classHash"`
	RaceHash   int `json:"raceHash"`
	GenderHash int `json:"genderHash"`

	// Level of the character if available. Zero if it is not available.
	CharacterLevel int `json:"characterLevel"`

	// Light Level of the character if available. Zero if it is not available.
	LightLevel int `json:"lightLevel"`

	// Details about the player as they are known on BungieNet. This will be undefined if the player has
	// marked their credential private, or does not have a BungieNet account.
	BungieNetUserInfo UserInfoCard `json:"bungieNetUserInfo"`

	// Current clan name for the player. This value may be null or an empty string if the user does not
	// have a clan.
	ClanName string `json:"clanName"`

	// Current clan tag for the player. This value may be null or an empty string if the user does not have
	// a clan.
	ClanTag string `json:"clanTag"`

	// If we know the emblem's hash, this can be used to look up the player's emblem at the time of a match
	// when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to
	// obtain it).
	EmblemHash int `json:"emblemHash"`
}
