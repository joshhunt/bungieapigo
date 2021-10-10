package bungieapigo

// This describes links between the current graph and others, as well as when that link is
// relevant.
type DestinyLinkedGraphDefinition struct {
    Description string `json:"description"`
    Name string `json:"name"`

    // Where the sausage gets made. Unlock Expressions are the foundation of the game's gating
    // mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values
    // for certain states, using a sufficient amount of logical operators such that unlock
    // expressions are effectively Turing complete.
    // Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from
    // Babel.
    UnlockExpression DestinyUnlockExpressionDefinition `json:"unlockExpression"`

    LinkedGraphId int `json:"linkedGraphId"`
    LinkedGraphs []DestinyLinkedGraphEntryDefinition `json:"linkedGraphs"`
    Overview string `json:"overview"`
}

