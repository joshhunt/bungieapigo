package bungieapigo

type EntityActionResult struct {
	EntityId int64              `json:"entityId,string"`
	Result   PlatformErrorCodes `json:"result"`
}
