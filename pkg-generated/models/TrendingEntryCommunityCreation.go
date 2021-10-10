package bungieapigo

type TrendingEntryCommunityCreation struct {
    Media string `json:"media"`
    Title string `json:"title"`
    Author string `json:"author"`
    AuthorMembershipId int64 `json:"authorMembershipId"`
    PostId int64 `json:"postId"`
    Body string `json:"body"`
    Upvotes int `json:"upvotes"`
}

