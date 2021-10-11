package bungieapigo

type PollResponse struct {
	TopicId    int64        `json:"topicId,string"`
	Results    []PollResult `json:"results"`
	TotalVotes int          `json:"totalVotes"`
}
