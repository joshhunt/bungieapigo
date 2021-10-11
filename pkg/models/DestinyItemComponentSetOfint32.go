package bungieapigo

type DestinyItemComponentSetOfint32 struct {
	Instances      DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent       `json:"instances"`
	Perks          DictionaryComponentResponseOfint32AndDestinyItemPerksComponent          `json:"perks"`
	RenderData     DictionaryComponentResponseOfint32AndDestinyItemRenderComponent         `json:"renderData"`
	Stats          DictionaryComponentResponseOfint32AndDestinyItemStatsComponent          `json:"stats"`
	Sockets        DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent        `json:"sockets"`
	ReusablePlugs  DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent  `json:"reusablePlugs"`
	PlugObjectives DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent `json:"plugObjectives"`
	TalentGrids    DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent     `json:"talentGrids"`
	PlugStates     DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent          `json:"plugStates"`
	Objectives     DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent     `json:"objectives"`
}
