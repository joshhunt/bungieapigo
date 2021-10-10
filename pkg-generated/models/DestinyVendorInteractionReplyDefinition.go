package bungieapigo

// When the interaction is replied to, Reward sites will fire and items potentially selected
// based on whether the given unlock expression is TRUE.
// You can potentially choose one from multiple replies when replying to an interaction: this is
// how you get either/or rewards from vendors.
type DestinyVendorInteractionReplyDefinition struct {

    // The rewards granted upon responding to the vendor.
    ItemRewardsSelection DestinyVendorInteractionRewardSelection `json:"itemRewardsSelection"`


    // The localized text for the reply.
    Reply string `json:"reply"`


    // An enum indicating the type of reply being made.
    ReplyType DestinyVendorReplyType `json:"replyType"`

}

