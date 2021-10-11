package bungieapigo

type DestinyActivityLoadoutRequirement struct {
	EquipmentSlotHash         int                  `json:"equipmentSlotHash"`
	AllowedEquippedItemHashes []int                `json:"allowedEquippedItemHashes"`
	AllowedWeaponSubTypes     []DestinyItemSubType `json:"allowedWeaponSubTypes"`
}
