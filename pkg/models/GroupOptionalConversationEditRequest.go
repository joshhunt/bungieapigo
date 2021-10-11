package bungieapigo

type GroupOptionalConversationEditRequest struct {
	ChatEnabled  bool   `json:"chatEnabled"`
	ChatName     string `json:"chatName"`
	ChatSecurity int    `json:"chatSecurity"`
}
