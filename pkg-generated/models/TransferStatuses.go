package bungieAPI

// Whether you can transfer an item, and why not if you can't.
type TransferStatuses int

const (

	// The item can be transferred.
	TransferStatusesCanTransfer = 0

	// You can't transfer the item because it is equipped on a character.
	TransferStatusesItemIsEquipped = 1

	// The item is defined as not transferrable in its
	// DestinyInventoryItemDefinition.nonTransferrable property.
	TransferStatusesNotTransferrable = 2

	// You could transfer the item, but the place you're trying to put it has run out of room! Check your
	// remaining Vault and/or character space.
	TransferStatusesNoRoomInDestination = 4
)
