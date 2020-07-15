using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents types of Energy that can be used for costs and payments related to Armor 2.0 mods.
	/// </summary>
	[DataContract]
	public class DestinyEnergyTypeDefinition{

		/// <summary>
		/// The description of the energy type, icon etc...
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A variant of the icon that is transparent and colorless.
		/// </summary>
		[DataMember(Name="transparentIconPath", EmitDefaultValue=false)]
		public string TransparentIconPath { get; set; }

		/// <summary>
		/// If TRUE, the game shows this Energy type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.
		/// </summary>
		[DataMember(Name="showIcon", EmitDefaultValue=false)]
		public bool ShowIcon { get; set; }

		/// <summary>
		/// We have an enumeration for Energy types for quick reference. This is the current definition's Energy type enum value.
		/// </summary>
		[DataMember(Name="enumValue", EmitDefaultValue=false)]
		public DestinyEnergyType EnumValue { get; set; }

		/// <summary>
		/// If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because "Any" is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use)
		/// </summary>
		[DataMember(Name="capacityStatHash", EmitDefaultValue=false)]
		public uint CapacityStatHash { get; set; }

		/// <summary>
		/// If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug's raw cost.
		/// </summary>
		[DataMember(Name="costStatHash", EmitDefaultValue=false)]
		public uint CostStatHash { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEnergyTypeDefinition);
        }

		public bool Equals(DestinyEnergyTypeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    TransparentIconPath == input.TransparentIconPath ||
                    (TransparentIconPath != null && TransparentIconPath.Equals(input.TransparentIconPath))
                ) &&
				(
                    ShowIcon == input.ShowIcon ||
                    (ShowIcon != null && ShowIcon.Equals(input.ShowIcon))
                ) &&
				(
                    EnumValue == input.EnumValue ||
                    (EnumValue != null && EnumValue.Equals(input.EnumValue))
                ) &&
				(
                    CapacityStatHash == input.CapacityStatHash ||
                    (CapacityStatHash != null && CapacityStatHash.Equals(input.CapacityStatHash))
                ) &&
				(
                    CostStatHash == input.CostStatHash ||
                    (CostStatHash != null && CostStatHash.Equals(input.CostStatHash))
                ) &&
				(
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
		}
	}
}

