package bungieapigo

type GroupOptionalConversation struct {
	GroupId        int64               `json:"groupId,string"`
	ConversationId int64               `json:"conversationId,string"`
	ChatEnabled    bool                `json:"chatEnabled"`
	ChatName       string              `json:"chatName"`
	ChatSecurity   ChatSecuritySetting `json:"chatSecurity"`
}
