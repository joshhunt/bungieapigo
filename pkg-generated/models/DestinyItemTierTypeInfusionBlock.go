package bungieAPI

type DestinyItemTierTypeInfusionBlock struct {

	// The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio = base quality transferred.
	BaseQualityTransferRatio float64 `json:"baseQualityTransferRatio"`

	// As long as InfuserQuality > InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser's quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)
	MinimumQualityIncrement int `json:"minimumQualityIncrement"`
}
