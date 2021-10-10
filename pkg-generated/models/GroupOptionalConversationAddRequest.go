package bungieAPI

type GroupOptionalConversationAddRequest struct {
	ChatName     string              `json:"chatName"`
	ChatSecurity ChatSecuritySetting `json:"chatSecurity"`
}
