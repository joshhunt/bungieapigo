package bungieapigo

// A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens.
// The vendor is showing you something, and asking you to reply to it by choosing an option or
// reward.
type DestinyVendorInteractionDefinition struct {

    // The position of this interaction in its parent array. Note that this is NOT content agnostic,
    // and should not be used as such.
    InteractionIndex int `json:"interactionIndex"`


    // The potential replies that the user can make to the interaction.
    Replies []DestinyVendorInteractionReplyDefinition `json:"replies"`


    // If >= 0, this is the category of sale items to show along with this interaction dialog.
    VendorCategoryIndex int `json:"vendorCategoryIndex"`


    // If this interaction dialog is about a quest, this is the questline related to the interaction.
    // You can use this to show the quest overview, or even the character's status with the quest if you
    // use it to find the character's current Quest Step by checking their inventory against this
    // questlineItemHash's DestinyInventoryItemDefinition.setData.
    QuestlineItemHash int `json:"questlineItemHash"`


    // If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If
    // empty, the interaction is not meant to show sacks.
    SackInteractionList []DestinyVendorInteractionSackEntryDefinition `json:"sackInteractionList"`


    // A UI hint for the behavior of the interaction screen. This is useful to determine what type of
    // interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a
    // reward for completing a quest. The hash isn't as useful as the Enum in retrospect, well what can
    // you do. Try using interactionType instead.
    UiInteractionType int `json:"uiInteractionType"`


    // The enumerated version of the possible UI hints for vendor interactions, which is a little
    // easier to grok than the hash found in uiInteractionType.
    InteractionType VendorInteractionType `json:"interactionType"`


    // If this interaction is displaying rewards, this is the text to use for the header of the
    // reward-displaying section of the interaction.
    RewardBlockLabel string `json:"rewardBlockLabel"`


    // If the vendor's reward list is sourced from one of his categories, this is the index into the
    // category array of items to show.
    RewardVendorCategoryIndex int `json:"rewardVendorCategoryIndex"`


    // If the vendor interaction has flavor text, this is some of it.
    FlavorLineOne string `json:"flavorLineOne"`


    // If the vendor interaction has flavor text, this is the rest of it.
    FlavorLineTwo string `json:"flavorLineTwo"`


    // The header for the interaction dialog.
    HeaderDisplayProperties DestinyDisplayPropertiesDefinition `json:"headerDisplayProperties"`


    // The localized text telling the player what to do when they see this dialog.
    Instructions string `json:"instructions"`

}

