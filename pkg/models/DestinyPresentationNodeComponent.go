package bungieapigo

type DestinyPresentationNodeComponent struct {
	State DestinyPresentationNodeState `json:"state"`

	// An optional property: presentation nodes MAY have objectives, which can be used to infer more
	// human readable data about the progress. However, progressValue and completionValue ought to
	// be considered the canonical values for progress on Progression Nodes.
	Objective DestinyObjectiveProgress `json:"objective"`

	// How much of the presentation node is considered to be completed so far by the given
	// character/profile.
	ProgressValue int `json:"progressValue"`

	// The value at which the presentation node is considered to be completed.
	CompletionValue int `json:"completionValue"`

	// If available, this is the current score for the record category that this node represents.
	RecordCategoryScore int `json:"recordCategoryScore"`
}
