package bungieAPI

import "time"

type AwaAuthorizationResult struct {

	// Indication of how the user responded to the request. If the value is "Approved" the actionToken
	// will contain the token that can be presented when performing the advanced write action.
	UserSelection AwaUserSelection `json:"userSelection"`

	ResponseReason AwaResponseReason `json:"responseReason"`

	// Message to the app developer to help understand the response.
	DeveloperNote string `json:"developerNote"`

	// Credential used to prove the user authorized an advanced write action.
	ActionToken string `json:"actionToken"`

	// This token may be used to perform the requested action this number of times, at a maximum. If this
	// value is 0, then there is no limit.
	MaximumNumberOfUses int `json:"maximumNumberOfUses"`

	// Time, UTC, when token expires.
	ValidUntil time.Time `json:"validUntil"`

	// Advanced Write Action Type from the permission request.
	Type AwaType `json:"type"`

	// MembershipType from the permission request.
	MembershipType BungieMembershipType `json:"membershipType"`
}
