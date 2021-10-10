package bungieapigo

type PollResponse struct {
    TopicId int64 `json:"topicId"`
    Results []PollResult `json:"results"`
    TotalVotes int `json:"totalVotes"`
}

