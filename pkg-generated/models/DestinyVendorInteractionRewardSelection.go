package bungieapigo

// When a Vendor Interaction provides rewards, they'll either let you choose one or let you have
// all of them. This determines which it will be.
type DestinyVendorInteractionRewardSelection int

const (
    DestinyVendorInteractionRewardSelectionNone = 0
    DestinyVendorInteractionRewardSelectionOne = 1
    DestinyVendorInteractionRewardSelectionAll = 2
)