package bungieapigo

import "time"

type PollResult struct {
	AnswerText          string    `json:"answerText"`
	AnswerSlot          int       `json:"answerSlot"`
	LastVoteDate        time.Time `json:"lastVoteDate"`
	Votes               int       `json:"votes"`
	RequestingUserVoted bool      `json:"requestingUserVoted"`
}
