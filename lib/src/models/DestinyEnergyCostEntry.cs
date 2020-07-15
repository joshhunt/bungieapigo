using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a &quot;masterworks-like&quot; mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
	[DataContract]
	public class DestinyEnergyCostEntry{

		/// <summary>
		/// The Energy cost for inserting this plug.
		/// </summary>
		[DataMember(Name="energyCost", EmitDefaultValue=false)]
		public long EnergyCost { get; set; }

		/// <summary>
		/// The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.
		/// </summary>
		[DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
		public uint EnergyTypeHash { get; set; }

		/// <summary>
		/// The type of energy that this plug costs, in enum form.
		/// </summary>
		[DataMember(Name="energyType", EmitDefaultValue=false)]
		public DestinyEnergyType EnergyType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEnergyCostEntry);
        }

		public bool Equals(DestinyEnergyCostEntry input)
		{
			if (input == null) return false;

			return
				(
                    EnergyCost == input.EnergyCost ||
                    (EnergyCost != null && EnergyCost.Equals(input.EnergyCost))
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

