package bungieapigo

type UserSearchResponse struct {
    SearchResults []UserSearchResponseDetail `json:"searchResults"`
    Page int `json:"page"`
    HasMore bool `json:"hasMore"`
}

