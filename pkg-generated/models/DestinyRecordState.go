package bungieAPI

// A Flags enumeration/bitmask where each bit represents a possible state that a Record/Triumph can be in.
type DestinyRecordState int

const (

	// If there are no flags set, the record is in a state where it *could* be redeemed, but it has not been yet.
	DestinyRecordStateNone = 0

	// If this is set, the completed record has been redeemed.
	DestinyRecordStateRecordRedeemed = 1

	// If this is set, there's a reward available from this Record but it's unavailable for redemption.
	DestinyRecordStateRewardUnavailable = 2

	// If this is set, the objective for this Record has not yet been completed.
	DestinyRecordStateObjectiveNotCompleted = 4

	// If this is set, the game recommends that you replace the display text of this Record with DestinyRecordDefinition.stateInfo.obscuredString.
	DestinyRecordStateObscured = 8

	// If this is set, the game recommends that you not show this record. Do what you will with this recommendation.
	DestinyRecordStateInvisible = 16

	// If this is set, you can't complete this record because you lack some permission that's required to complete it.
	DestinyRecordStateEntitlementUnowned = 32

	// If this is set, the record has a title (check DestinyRecordDefinition for title info) and you can equip it.
	DestinyRecordStateCanEquipTitle = 64
)
