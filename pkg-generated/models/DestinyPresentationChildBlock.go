package bungieapigo

type DestinyPresentationChildBlock struct {
    PresentationNodeType DestinyPresentationNodeType `json:"presentationNodeType"`
    ParentPresentationNodeHashes []int `json:"parentPresentationNodeHashes"`
    DisplayStyle DestinyPresentationDisplayStyle `json:"displayStyle"`
}

