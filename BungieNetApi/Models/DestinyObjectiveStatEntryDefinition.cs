using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Defines the conditions under which stat modifications will be applied to a Character while participating in an objective.
	/// </summary>
	[DataContract]
	public class DestinyObjectiveStatEntryDefinition{

		/// <summary>
		/// The stat being modified, and the value used.
		/// </summary>
		[DataMember(Name="stat", EmitDefaultValue=false)]
		public DestinyItemInvestmentStatDefinition Stat { get; set; }

		/// <summary>
		/// Whether it will be applied as long as the objective is active, when it's completed, or until it's completed.
		/// </summary>
		[DataMember(Name="style", EmitDefaultValue=false)]
		public DestinyObjectiveGrantStyle Style { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyObjectiveStatEntryDefinition);
        }

		public bool Equals(DestinyObjectiveStatEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Stat == input.Stat ||
                    (Stat != null && Stat.Equals(input.Stat))
                ) &&
				(
                    Style == input.Style ||
                    (Style != null && Style.Equals(input.Style))
                ) ;
		}
	}
}

