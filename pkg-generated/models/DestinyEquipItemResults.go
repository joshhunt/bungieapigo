package bungieapigo

// The results of a bulk Equipping operation performed through the Destiny API.
type DestinyEquipItemResults struct {
    EquipResults []DestinyEquipItemResult `json:"equipResults"`
}

