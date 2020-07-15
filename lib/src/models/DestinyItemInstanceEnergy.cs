using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemInstanceEnergy{

		/// <summary>
		/// The type of energy for this item. Plugs that require Energy can only be inserted if they have the "Any" Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.
		/// </summary>
		[DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
		public uint EnergyTypeHash { get; set; }

		/// <summary>
		/// This is the enum version of the Energy Type value, for convenience.
		/// </summary>
		[DataMember(Name="energyType", EmitDefaultValue=false)]
		public DestinyEnergyType EnergyType { get; set; }

		/// <summary>
		/// The total capacity of Energy that the item currently has, regardless of if it is currently being used.
		/// </summary>
		[DataMember(Name="energyCapacity", EmitDefaultValue=false)]
		public long EnergyCapacity { get; set; }

		/// <summary>
		/// The amount of Energy currently in use by inserted plugs.
		/// </summary>
		[DataMember(Name="energyUsed", EmitDefaultValue=false)]
		public long EnergyUsed { get; set; }

		/// <summary>
		/// The amount of energy still available for inserting new plugs.
		/// </summary>
		[DataMember(Name="energyUnused", EmitDefaultValue=false)]
		public long EnergyUnused { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemInstanceEnergy);
        }

		public bool Equals(DestinyItemInstanceEnergy input)
		{
			if (input == null) return false;

			return
				(
                    EnergyTypeHash == input.EnergyTypeHash ||
                    (EnergyTypeHash != null && EnergyTypeHash.Equals(input.EnergyTypeHash))
                ) &&
				(
                    EnergyType == input.EnergyType ||
                    (EnergyType != null && EnergyType.Equals(input.EnergyType))
                ) &&
				(
                    EnergyCapacity == input.EnergyCapacity ||
                    (EnergyCapacity != null && EnergyCapacity.Equals(input.EnergyCapacity))
                ) &&
				(
                    EnergyUsed == input.EnergyUsed ||
                    (EnergyUsed != null && EnergyUsed.Equals(input.EnergyUsed))
                ) &&
				(
                    EnergyUnused == input.EnergyUnused ||
                    (EnergyUnused != null && EnergyUnused.Equals(input.EnergyUnused))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.EnergyTypeHash.GetHashCode();
				hashCode = hashCode * 59 + this.EnergyType.GetHashCode();
				hashCode = hashCode * 59 + this.EnergyCapacity.GetHashCode();
				hashCode = hashCode * 59 + this.EnergyUsed.GetHashCode();
				hashCode = hashCode * 59 + this.EnergyUnused.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

