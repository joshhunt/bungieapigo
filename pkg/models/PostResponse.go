package bungieapigo

import "time"

type PostResponse struct {
	LastReplyTimestamp  time.Time           `json:"lastReplyTimestamp"`
	IsPinned            bool                `json:"IsPinned"`
	UrlMediaType        ForumMediaType      `json:"urlMediaType"`
	Thumbnail           string              `json:"thumbnail"`
	Popularity          ForumPostPopularity `json:"popularity"`
	IsActive            bool                `json:"isActive"`
	IsAnnouncement      bool                `json:"isAnnouncement"`
	UserRating          int                 `json:"userRating"`
	UserHasRated        bool                `json:"userHasRated"`
	UserHasMutedPost    bool                `json:"userHasMutedPost"`
	LatestReplyPostId   int64               `json:"latestReplyPostId,string"`
	LatestReplyAuthorId int64               `json:"latestReplyAuthorId,string"`
	IgnoreStatus        IgnoreResponse      `json:"ignoreStatus"`
	Locale              string              `json:"locale"`
}
