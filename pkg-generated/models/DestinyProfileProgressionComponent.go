package bungieAPI

// The set of progression-related information that applies at a Profile-wide level for your Destiny experience. This differs from the Jimi Hendrix Experience because there's less guitars on fire. Yet. #spoileralert?
// This will include information such as Checklist info.
type DestinyProfileProgressionComponent struct {

	// The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)
	// For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
	Checklists map[int]map[int]bool `json:"checklists"`

	// Data related to your progress on the current season's artifact that is the same across characters.
	SeasonalArtifact DestinyArtifactProfileScoped `json:"seasonalArtifact"`
}
