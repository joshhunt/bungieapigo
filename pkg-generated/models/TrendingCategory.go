package bungieapigo

type TrendingCategory struct {
    CategoryName string `json:"categoryName"`
    Entries SearchResultOfTrendingEntry `json:"entries"`
    CategoryId string `json:"categoryId"`
}

