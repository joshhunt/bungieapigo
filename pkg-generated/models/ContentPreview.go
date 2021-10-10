package bungieapigo

type ContentPreview struct {
    Name string `json:"name"`
    Path string `json:"path"`
    ItemInSet bool `json:"itemInSet"`
    SetTag string `json:"setTag"`
    SetNesting int `json:"setNesting"`
    UseSetId int `json:"useSetId"`
}

