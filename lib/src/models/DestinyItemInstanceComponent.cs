using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// If an item is "instanced", this will contain information about the item's instance that doesn't fit easily into other components. One might say this is the "essential" instance data for the item.
	/// </summary>
	/// <summary>
	/// Items are instanced if they require information or state that can vary. For instance, weapons are Instanced: they are given a unique identifier, uniquely generated stats, and can have their properties altered. Non-instanced items have none of these things: for instance, Glimmer has no unique properties aside from how much of it you own.
	/// </summary>
	/// <summary>
	/// You can tell from an item's definition whether it will be instanced or not by looking at the DestinyInventoryItemDefinition's definition.inventory.isInstanceItem property.
	/// </summary>
	[DataContract]
	public class DestinyItemInstanceComponent{

		/// <summary>
		/// If the item has a damage type, this is the item's current damage type.
		/// </summary>
		[DataMember(Name="damageType", EmitDefaultValue=false)]
		public DamageType DamageType { get; set; }

		/// <summary>
		/// The current damage type's hash, so you can look up localized info and icons for it.
		/// </summary>
		[DataMember(Name="damageTypeHash", EmitDefaultValue=false)]
		public uint DamageTypeHash { get; set; }

		/// <summary>
		/// The item stat that we consider to be "primary" for the item. For instance, this would be "Attack" for Weapons or "Defense" for armor.
		/// </summary>
		[DataMember(Name="primaryStat", EmitDefaultValue=false)]
		public DestinyStat PrimaryStat { get; set; }

		/// <summary>
		/// The Item's "Level" has the most significant bearing on its stats, such as Light and Power.
		/// </summary>
		[DataMember(Name="itemLevel", EmitDefaultValue=false)]
		public long ItemLevel { get; set; }

		/// <summary>
		/// The "Quality" of the item has a lesser - but still impactful - bearing on stats like Light and Power.
		/// </summary>
		[DataMember(Name="quality", EmitDefaultValue=false)]
		public long Quality { get; set; }

		/// <summary>
		/// Is the item currently equipped on the given character?
		/// </summary>
		[DataMember(Name="isEquipped", EmitDefaultValue=false)]
		public bool IsEquipped { get; set; }

		/// <summary>
		/// If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details.
		/// </summary>
		[DataMember(Name="canEquip", EmitDefaultValue=false)]
		public bool CanEquip { get; set; }

		/// <summary>
		/// If the item cannot be equipped until you reach a certain level, that level will be reflected here.
		/// </summary>
		[DataMember(Name="equipRequiredLevel", EmitDefaultValue=false)]
		public long EquipRequiredLevel { get; set; }

		/// <summary>
		/// Sometimes, there are limitations to equipping that are represented by character-level flags called "unlocks".
		/// </summary>
		/// <summary>
		/// This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes.
		/// </summary>
		[DataMember(Name="unlockHashesRequiredToEquip", EmitDefaultValue=false)]
		public List<uint> UnlockHashesRequiredToEquip { get; set; }

		/// <summary>
		/// If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn't equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel.
		/// </summary>
		[DataMember(Name="cannotEquipReason", EmitDefaultValue=false)]
		public EquipFailureReason CannotEquipReason { get; set; }

		/// <summary>
		/// If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details.
		/// </summary>
		[DataMember(Name="breakerType", EmitDefaultValue=false)]
		public long BreakerType { get; set; }

		/// <summary>
		/// If populated, this is the hash identifier for the item's breaker type. See DestinyBreakerTypeDefinition for more details.
		/// </summary>
		[DataMember(Name="breakerTypeHash", EmitDefaultValue=false)]
		public uint BreakerTypeHash { get; set; }

		/// <summary>
		/// IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current details of its energy type and available capacity to spend energy points.
		/// </summary>
		[DataMember(Name="energy", EmitDefaultValue=false)]
		public DestinyItemInstanceEnergy Energy { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemInstanceComponent);
        }

		public bool Equals(DestinyItemInstanceComponent input)
		{
			if (input == null) return false;

			return
				(
                    DamageType == input.DamageType ||
                    (DamageType != null && DamageType.Equals(input.DamageType))
                ) &&
				(
                    DamageTypeHash == input.DamageTypeHash ||
                    (DamageTypeHash != null && DamageTypeHash.Equals(input.DamageTypeHash))
                ) &&
				(
                    PrimaryStat == input.PrimaryStat ||
                    (PrimaryStat != null && PrimaryStat.Equals(input.PrimaryStat))
                ) &&
				(
                    ItemLevel == input.ItemLevel ||
                    (ItemLevel != null && ItemLevel.Equals(input.ItemLevel))
                ) &&
				(
                    Quality == input.Quality ||
                    (Quality != null && Quality.Equals(input.Quality))
                ) &&
				(
                    IsEquipped == input.IsEquipped ||
                    (IsEquipped != null && IsEquipped.Equals(input.IsEquipped))
                ) &&
				(
                    CanEquip == input.CanEquip ||
                    (CanEquip != null && CanEquip.Equals(input.CanEquip))
                ) &&
				(
                    EquipRequiredLevel == input.EquipRequiredLevel ||
                    (EquipRequiredLevel != null && EquipRequiredLevel.Equals(input.EquipRequiredLevel))
                ) &&
				(
                    UnlockHashesRequiredToEquip == input.UnlockHashesRequiredToEquip ||
                    (UnlockHashesRequiredToEquip != null && UnlockHashesRequiredToEquip.Equals(input.UnlockHashesRequiredToEquip))
                ) &&
				(
                    CannotEquipReason == input.CannotEquipReason ||
                    (CannotEquipReason != null && CannotEquipReason.Equals(input.CannotEquipReason))
                ) &&
				(
                    BreakerType == input.BreakerType ||
                    (BreakerType != null && BreakerType.Equals(input.BreakerType))
                ) &&
				(
                    BreakerTypeHash == input.BreakerTypeHash ||
                    (BreakerTypeHash != null && BreakerTypeHash.Equals(input.BreakerTypeHash))
                ) &&
				(
                    Energy == input.Energy ||
                    (Energy != null && Energy.Equals(input.Energy))
                ) ;
		}
	}
}

