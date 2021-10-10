package bungieapigo

// This determines the type of reply that a Vendor will have during an Interaction.
type DestinyVendorReplyType int

const (
    DestinyVendorReplyTypeAccept = 0
    DestinyVendorReplyTypeDecline = 1
    DestinyVendorReplyTypeComplete = 2
)