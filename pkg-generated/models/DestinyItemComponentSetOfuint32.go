package bungieAPI

type DestinyItemComponentSetOfuint32 struct {
	Instances      DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent       `json:"instances"`
	Perks          DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent          `json:"perks"`
	RenderData     DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent         `json:"renderData"`
	Stats          DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent          `json:"stats"`
	Sockets        DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent        `json:"sockets"`
	ReusablePlugs  DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent  `json:"reusablePlugs"`
	PlugObjectives DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent `json:"plugObjectives"`
	TalentGrids    DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent     `json:"talentGrids"`
	PlugStates     DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent           `json:"plugStates"`
	Objectives     DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent     `json:"objectives"`
}
