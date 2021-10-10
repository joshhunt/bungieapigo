package bungieapigo

type VendorItemStatus int

const (
    VendorItemStatusSuccess = 0
    VendorItemStatusNoInventorySpace = 1
    VendorItemStatusNoFunds = 2
    VendorItemStatusNoProgression = 4
    VendorItemStatusNoUnlock = 8
    VendorItemStatusNoQuantity = 16
    VendorItemStatusOutsidePurchaseWindow = 32
    VendorItemStatusNotAvailable = 64
    VendorItemStatusUniquenessViolation = 128
    VendorItemStatusUnknownError = 256
    VendorItemStatusAlreadySelling = 512
    VendorItemStatusUnsellable = 1024
    VendorItemStatusSellingInhibited = 2048
    VendorItemStatusAlreadyOwned = 4096
    VendorItemStatusDisplayOnly = 8192
)