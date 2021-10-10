package bungieAPI

// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible
// "modes".
// If you are querying for a group, you can pass any of the properties below.
// If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be
// null or undefined in your request, not just empty string/default values):
// - groupMemberCountFilter - localeFilter - tagText
// If you pass these, you will get a useless InvalidParameters error.
type GroupQuery struct {
	Name                     string         `json:"name"`
	GroupType                GroupType      `json:"groupType"`
	CreationDate             GroupDateRange `json:"creationDate"`
	SortBy                   GroupSortBy    `json:"sortBy"`
	GroupMemberCountFilter   int            `json:"groupMemberCountFilter"`
	LocaleFilter             string         `json:"localeFilter"`
	TagText                  string         `json:"tagText"`
	ItemsPerPage             int            `json:"itemsPerPage"`
	CurrentPage              int            `json:"currentPage"`
	RequestContinuationToken string         `json:"requestContinuationToken"`
}
