using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyActivityLoadoutRequirement{

		[DataMember(Name="equipmentSlotHash", EmitDefaultValue=false)]
		public uint EquipmentSlotHash { get; set; }

		[DataMember(Name="allowedEquippedItemHashes", EmitDefaultValue=false)]
		public List<uint> AllowedEquippedItemHashes { get; set; }

		[DataMember(Name="allowedWeaponSubTypes", EmitDefaultValue=false)]
		public List<DestinyItemSubType> AllowedWeaponSubTypes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityLoadoutRequirement);
        }

		public bool Equals(DestinyActivityLoadoutRequirement input)
		{
			if (input == null) return false;

			return
				(
                    EquipmentSlotHash == input.EquipmentSlotHash ||
                    (EquipmentSlotHash != null && EquipmentSlotHash.Equals(input.EquipmentSlotHash))
                ) &&
				(
                    AllowedEquippedItemHashes == input.AllowedEquippedItemHashes ||
                    (AllowedEquippedItemHashes != null && AllowedEquippedItemHashes.Equals(input.AllowedEquippedItemHashes))
                ) &&
				(
                    AllowedWeaponSubTypes == input.AllowedWeaponSubTypes ||
                    (AllowedWeaponSubTypes != null && AllowedWeaponSubTypes.Equals(input.AllowedWeaponSubTypes))
                ) ;
		}
	}
}

