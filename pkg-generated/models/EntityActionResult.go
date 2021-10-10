package bungieAPI

type EntityActionResult struct {
	EntityId int64              `json:"entityId"`
	Result   PlatformErrorCodes `json:"result"`
}
