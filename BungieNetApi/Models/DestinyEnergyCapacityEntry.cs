using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much "Energy" can be spent on activating plugs for this item.
	/// </summary>
	[DataContract]
	public class DestinyEnergyCapacityEntry{

		/// <summary>
		/// How much energy capacity this plug provides.
		/// </summary>
		[DataMember(Name="capacityValue", EmitDefaultValue=false)]
		public long CapacityValue { get; set; }

		/// <summary>
		/// Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.
		/// </summary>
		[DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
		public uint EnergyTypeHash { get; set; }

		/// <summary>
		/// The Energy Type for this energy capacity, in enum form for easy use.
		/// </summary>
		[DataMember(Name="energyType", EmitDefaultValue=false)]
		public DestinyEnergyType EnergyType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEnergyCapacityEntry);
        }

		public bool Equals(DestinyEnergyCapacityEntry input)
		{
			if (input == null) return false;

			return
				(
                    CapacityValue == input.CapacityValue ||
                    (CapacityValue != null && CapacityValue.Equals(input.CapacityValue))
                ) &&
				(
                    EnergyTypeHash == input.EnergyTypeHash ||
                    (EnergyTypeHash != null && EnergyTypeHash.Equals(input.EnergyTypeHash))
                ) &&
				(
                    EnergyType == input.EnergyType ||
                    (EnergyType != null && EnergyType.Equals(input.EnergyType))
                ) ;
		}
	}
}

