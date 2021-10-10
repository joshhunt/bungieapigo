package bungieAPI

type DestinyRecordCompletionBlock struct {

	// The number of objectives that must be completed before the objective is considered "complete"
	PartialCompletionObjectiveCountThreshold int                     `json:"partialCompletionObjectiveCountThreshold"`
	ScoreValue                               int                     `json:"ScoreValue"`
	ShouldFireToast                          bool                    `json:"shouldFireToast"`
	ToastStyle                               DestinyRecordToastStyle `json:"toastStyle"`
}
