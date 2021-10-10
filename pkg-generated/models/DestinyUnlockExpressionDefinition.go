package bungieAPI

// Where the sausage gets made. Unlock Expressions are the foundation of the game's gating
// mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values
// for certain states, using a sufficient amount of logical operators such that unlock
// expressions are effectively Turing complete.
// Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from
// Babel.
type DestinyUnlockExpressionDefinition struct {

	// A shortcut for determining the most restrictive gating that this expression performs. See the
	// DestinyGatingScope enum's documentation for more details.
	Scope DestinyGatingScope `json:"scope"`
}
