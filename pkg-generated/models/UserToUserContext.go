package bungieapigo
import "time"

type UserToUserContext struct {
    IsFollowing bool `json:"isFollowing"`
    IgnoreStatus IgnoreResponse `json:"ignoreStatus"`
    GlobalIgnoreEndDate time.Time `json:"globalIgnoreEndDate"`
}

