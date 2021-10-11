package bungieapigo

import "time"

type FireteamSummary struct {
	FireteamId                  int64            `json:"fireteamId"`
	GroupId                     int64            `json:"groupId"`
	Platform                    FireteamPlatform `json:"platform"`
	ActivityType                int              `json:"activityType"`
	IsImmediate                 bool             `json:"isImmediate"`
	ScheduledTime               time.Time        `json:"scheduledTime"`
	OwnerMembershipId           int64            `json:"ownerMembershipId"`
	PlayerSlotCount             int              `json:"playerSlotCount"`
	AlternateSlotCount          int              `json:"alternateSlotCount"`
	AvailablePlayerSlotCount    int              `json:"availablePlayerSlotCount"`
	AvailableAlternateSlotCount int              `json:"availableAlternateSlotCount"`
	Title                       string           `json:"title"`
	DateCreated                 time.Time        `json:"dateCreated"`
	DateModified                time.Time        `json:"dateModified"`
	IsPublic                    bool             `json:"isPublic"`
	Locale                      string           `json:"locale"`
	IsValid                     bool             `json:"isValid"`
	DatePlayerModified          time.Time        `json:"datePlayerModified"`
	TitleBeforeModeration       string           `json:"titleBeforeModeration"`
}
