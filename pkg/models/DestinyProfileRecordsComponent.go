package bungieapigo

type DestinyProfileRecordsComponent struct {

	// Your 'active' Triumphs score, maintained for backwards compatibility.
	Score int `json:"score"`

	// Your 'active' Triumphs score.
	ActiveScore int `json:"activeScore"`

	// Your 'legacy' Triumphs score.
	LegacyScore int `json:"legacyScore"`

	// Your 'lifetime' Triumphs score.
	LifetimeScore int `json:"lifetimeScore"`

	// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
	TrackedRecordHash int `json:"trackedRecordHash"`

	Records map[int]DestinyRecordComponent `json:"records"`

	// The hash for the root presentation node definition of Triumph categories.
	RecordCategoriesRootNodeHash int `json:"recordCategoriesRootNodeHash"`

	// The hash for the root presentation node definition of Triumph Seals.
	RecordSealsRootNodeHash int `json:"recordSealsRootNodeHash"`
}
