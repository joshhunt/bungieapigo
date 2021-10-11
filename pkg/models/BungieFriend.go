package bungieapigo

type BungieFriend struct {
	LastSeenAsMembershipId         int64                    `json:"lastSeenAsMembershipId"`
	LastSeenAsBungieMembershipType BungieMembershipType     `json:"lastSeenAsBungieMembershipType"`
	BungieGlobalDisplayName        string                   `json:"bungieGlobalDisplayName"`
	BungieGlobalDisplayNameCode    int                      `json:"bungieGlobalDisplayNameCode"`
	OnlineStatus                   PresenceStatus           `json:"onlineStatus"`
	OnlineTitle                    PresenceOnlineStateFlags `json:"onlineTitle"`
	Relationship                   FriendRelationshipState  `json:"relationship"`
	BungieNetUser                  GeneralUser              `json:"bungieNetUser"`
}
