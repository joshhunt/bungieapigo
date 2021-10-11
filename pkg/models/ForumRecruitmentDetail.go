package bungieapigo

type ForumRecruitmentDetail struct {
	TopicId              int64                          `json:"topicId"`
	MicrophoneRequired   bool                           `json:"microphoneRequired"`
	Intensity            ForumRecruitmentIntensityLabel `json:"intensity"`
	Tone                 ForumRecruitmentToneLabel      `json:"tone"`
	Approved             bool                           `json:"approved"`
	ConversationId       int64                          `json:"conversationId"`
	PlayerSlotsTotal     int                            `json:"playerSlotsTotal"`
	PlayerSlotsRemaining int                            `json:"playerSlotsRemaining"`
	Fireteam             []GeneralUser                  `json:"Fireteam"`
	KickedPlayerIds      []int64                        `json:"kickedPlayerIds"`
}
