package bungieapigo

// The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically
// have many of these states simultaneously: as a result, this was altered to be a flags
// enumeration/bitmask for v3.2.0.
type DestinyVendorItemState int

const (

    // There are no augments on the item.
    DestinyVendorItemStateNone = 0


    // Deprecated forever (probably). There was a time when Records were going to be implemented
    // through Vendors, and this field was relevant. Now they're implemented through Presentation
    // Nodes, and this field doesn't matter anymore.
    DestinyVendorItemStateIncomplete = 1


    // Deprecated forever (probably). See the description of the "Incomplete" value for the juicy
    // scoop.
    DestinyVendorItemStateRewardAvailable = 2


    // Deprecated forever (probably). See the description of the "Incomplete" value for the juicy
    // scoop.
    DestinyVendorItemStateComplete = 4


    // This item is considered to be "newly available", and should have some UI showing how shiny it is.
    DestinyVendorItemStateNew = 8


    // This item is being "featured", and should be shiny in a different way from items that are merely
    // new.
    DestinyVendorItemStateFeatured = 16


    // This item is only available for a limited time, and that time is approaching.
    DestinyVendorItemStateEnding = 32


    // This item is "on sale". Get it while it's hot.
    DestinyVendorItemStateOnSale = 64


    // This item is already owned.
    DestinyVendorItemStateOwned = 128


    // This item should be shown with a "wide view" instead of normal icon view.
    DestinyVendorItemStateWideView = 256


    // This indicates that you should show some kind of attention-requesting indicator on the item,
    // in a similar manner to items in the nexus that have such notifications.
    DestinyVendorItemStateNexusAttention = 512


    // This indicates that the item has some sort of a 'set' discount.
    DestinyVendorItemStateSetDiscount = 1024


    // This indicates that the item has a price drop.
    DestinyVendorItemStatePriceDrop = 2048


    // This indicates that the item is a daily offer.
    DestinyVendorItemStateDailyOffer = 4096


    // This indicates that the item is for charity.
    DestinyVendorItemStateCharity = 8192


    // This indicates that the item has a seasonal reward expiration.
    DestinyVendorItemStateSeasonalRewardExpiration = 16384


    // This indicates that the sale item is the best deal among different choices.
    DestinyVendorItemStateBestDeal = 32768


    // This indicates that the sale item is popular.
    DestinyVendorItemStatePopular = 65536

)