package bungieapigo

type CommentSummary struct {
	TopicId      int64 `json:"topicId,string"`
	CommentCount int   `json:"commentCount"`
}
