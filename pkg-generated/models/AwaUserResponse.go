package bungieapigo

type AwaUserResponse struct {

    // Indication of the selection the user has made (Approving or rejecting the action)
    Selection AwaUserSelection `json:"selection"`


    // Correlation ID of the request
    CorrelationId string `json:"correlationId"`


    // Secret nonce received via the PUSH notification.
    Nonce []int `json:"nonce"`

}

