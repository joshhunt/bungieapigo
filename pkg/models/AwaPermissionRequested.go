package bungieapigo

type AwaPermissionRequested struct {

	// Type of advanced write action.
	Type AwaType `json:"type"`

	// Item instance ID the action shall be applied to. This is optional for all but a new AwaType
	// values. Rule of thumb is to provide the item instance ID if one is available.
	AffectedItemId int64 `json:"affectedItemId"`

	// Destiny membership type of the account to modify.
	MembershipType BungieMembershipType `json:"membershipType"`

	// Destiny character ID, if applicable, that will be affected by the action.
	CharacterId int64 `json:"characterId"`
}
