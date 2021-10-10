package bungieapigo

// An enumeration of the known UI interactions for Vendors.
type VendorInteractionType int

const (
    VendorInteractionTypeUnknown = 0

    // An empty interaction. If this ends up in content, it is probably a game bug.
    VendorInteractionTypeUndefined = 1


    // An interaction shown when you complete a quest and receive a reward.
    VendorInteractionTypeQuestComplete = 2


    // An interaction shown when you talk to a Vendor as an intermediary step of a quest.
    VendorInteractionTypeQuestContinue = 3


    // An interaction shown when you are previewing the vendor's reputation rewards.
    VendorInteractionTypeReputationPreview = 4


    // An interaction shown when you rank up with the vendor.
    VendorInteractionTypeRankUpReward = 5


    // An interaction shown when you have tokens to turn in for the vendor.
    VendorInteractionTypeTokenTurnIn = 6


    // An interaction shown when you're accepting a new quest.
    VendorInteractionTypeQuestAccept = 7


    // Honestly, this doesn't seem consistent to me. It is used to give you choices in the Cryptarch as
    // well as some reward prompts by the Eververse vendor. I'll have to look into that further at some
    // point.
    VendorInteractionTypeProgressTab = 8


    // These seem even less consistent. I don't know what these are.
    VendorInteractionTypeEnd = 9


    // Also seem inconsistent. I also don't know what these are offhand.
    VendorInteractionTypeStart = 10

)