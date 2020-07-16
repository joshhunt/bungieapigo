using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// Items that can be equipped define this block. It contains information we need to understand how and when the item can be equipped.
    /// </summary>
    [DataContract]
    public class DestinyEquippingBlockDefinition
    {
        /// <summary>
        /// If the item is part of a gearset, this is a reference to that gearset item.
        /// </summary>
        [DataMember(Name = "gearsetItemHash", EmitDefaultValue = false)]
        public uint GearsetItemHash { get; set; }

        /// <summary>
        /// If defined, this is the label used to check if the item has other items of matching types already equipped. 
        /// </summary>
        /// <summary>
        /// For instance, when you aren't allowed to equip more than one Exotic Weapon, that's because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item's uniqueLabel vs. all other already equipped items (other than the item in the slot that's about to be occupied).
        /// </summary>
        [DataMember(Name = "uniqueLabel", EmitDefaultValue = false)]
        public string UniqueLabel { get; set; }

        /// <summary>
        /// The hash of that unique label. Does not point to a specific definition.
        /// </summary>
        [DataMember(Name = "uniqueLabelHash", EmitDefaultValue = false)]
        public uint UniqueLabelHash { get; set; }

        /// <summary>
        /// An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
        /// </summary>
        [DataMember(Name = "equipmentSlotTypeHash", EmitDefaultValue = false)]
        public uint EquipmentSlotTypeHash { get; set; }

        /// <summary>
        /// These are custom attributes on the equippability of the item.
        /// </summary>
        /// <summary>
        /// For now, this can only be "equip on acquire", which would mean that the item will be automatically equipped as soon as you pick it up.
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public EquippingItemBlockAttributes Attributes { get; set; }

        /// <summary>
        /// Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.
        /// </summary>
        [DataMember(Name = "ammoType", EmitDefaultValue = false)]
        public DestinyAmmunitionType AmmoType { get; set; }

        /// <summary>
        /// These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.
        /// </summary>
        [DataMember(Name = "displayStrings", EmitDefaultValue = false)]
        public List<string> DisplayStrings { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEquippingBlockDefinition);
        }

        public bool Equals(DestinyEquippingBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    GearsetItemHash == input.GearsetItemHash ||
                    (GearsetItemHash != null && GearsetItemHash.Equals(input.GearsetItemHash))
                ) &&
                (
                    UniqueLabel == input.UniqueLabel ||
                    (UniqueLabel != null && UniqueLabel.Equals(input.UniqueLabel))
                ) &&
                (
                    UniqueLabelHash == input.UniqueLabelHash ||
                    (UniqueLabelHash != null && UniqueLabelHash.Equals(input.UniqueLabelHash))
                ) &&
                (
                    EquipmentSlotTypeHash == input.EquipmentSlotTypeHash ||
                    (EquipmentSlotTypeHash != null && EquipmentSlotTypeHash.Equals(input.EquipmentSlotTypeHash))
                ) &&
                (
                    Attributes == input.Attributes ||
                    (Attributes != null && Attributes.Equals(input.Attributes))
                ) &&
                (
                    AmmoType == input.AmmoType ||
                    (AmmoType != null && AmmoType.Equals(input.AmmoType))
                ) &&
                (
                    DisplayStrings == input.DisplayStrings ||
                    (DisplayStrings != null && DisplayStrings.Equals(input.DisplayStrings))
                ) ;
        }
    }
}

