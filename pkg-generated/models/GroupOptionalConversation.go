package bungieapigo

type GroupOptionalConversation struct {
    GroupId int64 `json:"groupId"`
    ConversationId int64 `json:"conversationId"`
    ChatEnabled bool `json:"chatEnabled"`
    ChatName string `json:"chatName"`
    ChatSecurity ChatSecuritySetting `json:"chatSecurity"`
}

