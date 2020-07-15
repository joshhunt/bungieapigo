using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.
	/// Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points&#x2F;experience at the same time.
	[DataContract]
	public class DestinyProgressionRewardDefinition{

		/// <summary>
		/// The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.
		/// </summary>
		[DataMember(Name="progressionMappingHash", EmitDefaultValue=false)]
		public uint ProgressionMappingHash { get; set; }

		/// <summary>
		/// The amount of experience to give to each of the mapped progressions.
		/// </summary>
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public long Amount { get; set; }

		/// <summary>
		/// If true, the game's internal mechanisms to throttle progression should be applied.
		/// </summary>
		[DataMember(Name="applyThrottles", EmitDefaultValue=false)]
		public bool ApplyThrottles { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProgressionRewardDefinition);
        }

		public bool Equals(DestinyProgressionRewardDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ProgressionMappingHash == input.ProgressionMappingHash ||
                    (ProgressionMappingHash != null && ProgressionMappingHash.Equals(input.ProgressionMappingHash))
                ) &&
				(
                    Amount == input.Amount ||
                    (Amount != null && Amount.Equals(input.Amount))
                ) &&
				(
                    ApplyThrottles == input.ApplyThrottles ||
                    (ApplyThrottles != null && ApplyThrottles.Equals(input.ApplyThrottles))
                ) ;
		}
	}
}

