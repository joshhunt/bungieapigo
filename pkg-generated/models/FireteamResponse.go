package bungieapigo

type FireteamResponse struct {
    Summary FireteamSummary `json:"Summary"`
    Members []FireteamMember `json:"Members"`
    Alternates []FireteamMember `json:"Alternates"`
}

