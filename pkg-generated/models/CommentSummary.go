package bungieAPI

type CommentSummary struct {
	TopicId      int64 `json:"topicId"`
	CommentCount int   `json:"commentCount"`
}