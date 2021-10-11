package bungieapigo

// Defines the conditions under which stat modifications will be applied to a Character while
// participating in an objective.
type DestinyObjectiveStatEntryDefinition struct {

	// The stat being modified, and the value used.
	Stat DestinyItemInvestmentStatDefinition `json:"stat"`

	// Whether it will be applied as long as the objective is active, when it's completed, or until it's
	// completed.
	Style DestinyObjectiveGrantStyle `json:"style"`
}
