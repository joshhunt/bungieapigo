package bungieAPI

// The results of an Equipping operation performed through the Destiny API.
type DestinyEquipItemResult struct {

	// The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)
	ItemInstanceId int64 `json:"itemInstanceId"`

	// A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.
	EquipStatus PlatformErrorCodes `json:"equipStatus"`
}
