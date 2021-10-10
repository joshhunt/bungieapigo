package bungieapigo

type DestinyPostGameCarnageReportTeamEntry struct {

    // Integer ID for the team.
    TeamId int `json:"teamId"`


    // Team's standing relative to other teams.
    Standing DestinyHistoricalStatsValue `json:"standing"`


    // Score earned by the team
    Score DestinyHistoricalStatsValue `json:"score"`


    // Alpha or Bravo
    TeamName string `json:"teamName"`

}

