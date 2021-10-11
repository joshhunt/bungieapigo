package bungieapigo

type SearchResultOfFireteamSummary struct {
	Results                      []FireteamSummary `json:"results"`
	TotalResults                 int               `json:"totalResults"`
	HasMore                      bool              `json:"hasMore"`
	Query                        PagedQuery        `json:"query"`
	ReplacementContinuationToken string            `json:"replacementContinuationToken"`

	// If useTotalResults is true, then totalResults represents an accurate count.
	// If False, it does not, and may be estimated/only the size of the current page.
	// Either way, you should probably always only trust hasMore.
	// This is a long-held historical throwback to when we used to do paging with known total results.
	// Those queries toasted our database, and we were left to hastily alter our endpoints and create
	// backward- compatible shims, of which useTotalResults is one.
	UseTotalResults bool `json:"useTotalResults"`
}
