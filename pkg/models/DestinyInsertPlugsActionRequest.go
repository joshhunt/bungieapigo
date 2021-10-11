package bungieapigo

type DestinyInsertPlugsActionRequest struct {

	// Action token provided by the AwaGetActionToken API call.
	ActionToken string `json:"actionToken"`

	// The instance ID of the item having a plug inserted. Only instanced items can have sockets.
	ItemInstanceId int64 `json:"itemInstanceId,string"`

	// The plugs being inserted.
	Plug DestinyInsertPlugsRequestEntry `json:"plug"`

	CharacterId    int64                `json:"characterId,string"`
	MembershipType BungieMembershipType `json:"membershipType"`
}
