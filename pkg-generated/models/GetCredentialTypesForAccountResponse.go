package bungieAPI

type GetCredentialTypesForAccountResponse struct {
	CredentialType        BungieCredentialType `json:"credentialType"`
	CredentialDisplayName string               `json:"credentialDisplayName"`
	IsPublic              bool                 `json:"isPublic"`
	CredentialAsString    string               `json:"credentialAsString"`
}
