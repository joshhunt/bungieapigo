package bungieapigo

type AwaResponseReason int

const (
	AwaResponseReasonNone = 0

	// User provided an answer
	AwaResponseReasonAnswered = 1

	// The HTTP request timed out, a new request may be made and an answer may still be provided.
	AwaResponseReasonTimedOut = 2

	// This request was replaced by another request.
	AwaResponseReasonReplaced = 3
)
