package bungieapigo

type AwaInitializeResponse struct {

    // ID used to get the token. Present this ID to the user as it will identify this specific request on
    // their device.
    CorrelationId string `json:"correlationId"`


    // True if the PUSH message will only be sent to the device that made this request.
    SentToSelf bool `json:"sentToSelf"`

}

